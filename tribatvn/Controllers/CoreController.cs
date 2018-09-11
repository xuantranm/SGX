﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Common.Utilities;
using Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using Models;
using ViewModels;
using System.IO;

namespace tribatvn.Controllers
{
    public class CoreController : Controller
    {
        MongoDBContext dbContext = new MongoDBContext();
        IHostingEnvironment _hostingEnvironment;

        private readonly ILogger _logger;

        public IConfiguration Configuration { get; }

        // Use cookie
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CoreController(IConfiguration configuration, IHostingEnvironment env, ILogger<HomeController> logger, IHttpContextAccessor httpContextAccessor)
        {
            Configuration = configuration;
            _hostingEnvironment = env;
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            #region Language
            var cultureInfo = new CultureInfo("vi-VN");
            ViewData["Language"] = cultureInfo.Name;
            ViewData["LanguageHtmlTag"] = cultureInfo.TwoLetterISOLanguageName;
            #endregion
            return View();
        }

        #region Texts
        public IActionResult Text(TextSearch search)
        {
            // Search

            var viewModel = new TextViewModel
            {
                Search = search
            };
            return View(viewModel);
        }

        [Route("/text/create")]
        public IActionResult TextCreate()
        {
            var entity = new List<Text>();
            return View(entity);

        }

        [Route("/text/create")]
        public IActionResult TextCreate(List<Text> entity)
        {
            return View();
        }

        [Route("/text/edit")]
        public IActionResult TextEdit(int code)
        {
            var entity = dbContext.Texts.Find(m => m.Code.Equals(code)).ToList();
            return View(entity);
        }

        [Route("/text/edit")]
        public IActionResult TextEdit(List<Text> entity, int code)
        {
            return View();
        }

        [Route("/text/delete")]
        public IActionResult TextDelete(int code)
        {
            return View();
        }

        #endregion

        [Route("/core/product/")]
        public IActionResult Product()
        {
            #region Language
            var cultureInfo = new CultureInfo("vi-VN");
            ViewData["Language"] = cultureInfo.Name;
            ViewData["LanguageHtmlTag"] = cultureInfo.TwoLetterISOLanguageName;
            #endregion

            #region Dropdownlist
            var categories = dbContext.ProductCategorySales.Find(m => m.Language.Equals(cultureInfo.Name) && m.ParentCode.Equals(1));
            ViewData["Categories"] = categories.ToList();
            #endregion

            var list = dbContext.ProductSales.Find(m => m.Enable.Equals(true) && m.Language.Equals(cultureInfo.Name)).SortByDescending(m => m.CreatedDate).ToList();
            return View(list);
        }

        [Route("/core/product/create/")]
        public IActionResult ProductCreate()
        {
            #region Language
            var cultureInfo = new CultureInfo("vi-VN");
            ViewData["Language"] = cultureInfo.Name;
            ViewData["LanguageHtmlTag"] = cultureInfo.TwoLetterISOLanguageName;
            #endregion

            #region Dropdownlist
            var languages = dbContext.Languages.Find(m => m.Enable.Equals(true) && !m.Code.Equals(cultureInfo.TwoLetterISOLanguageName));
            ViewData["Languages"] = languages.ToList();

            var categories = dbContext.ProductCategorySales.Find(m => m.Language.Equals(cultureInfo.Name) && m.ParentCode.Equals(1));
            ViewData["Categories"] = categories.ToList();
            #endregion

            #region Setting
            var setting = dbContext.Settings.Find(m => m.Enable.Equals(true) && m.Key.Contains("google-api-key")).ToList();
            ViewData["GoogleApi1"] = setting[0];
            ViewData["GoogleApi2"] = setting[1];
            #endregion

            return View();
        }

        [HttpPost]
        [Route("/core/product/create/")]
        public IActionResult ProductCreate(ProductDataViewModel viewModel)
        {
            #region Language
            var cultureInfo = new CultureInfo("en-US");
            ViewData["Language"] = cultureInfo.Name;
            ViewData["LanguageHtmlTag"] = cultureInfo.TwoLetterISOLanguageName;
            #endregion

            #region System autofill: code (return newCode)
            var newCode = 1;
            var sort = Builders<ProductSale>.Sort.Descending("Code");
            var filter1 = Builders<ProductSale>.Filter.Empty;
            var lastRecords = dbContext.ProductSales.Find(filter1).Sort(sort).Limit(1);
            if (lastRecords != null)
            {
                newCode = lastRecords.First().Code + 1;
            }
            #endregion

            #region Images, each product 1 folder. (return images)
            var images = new List<Image>();
            var mapFolder = "images\\" + Constants.Link.Product + "\\" + newCode;
            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, mapFolder);
            if (!Directory.Exists(uploads))
            {
                Directory.CreateDirectory(uploads);
            }

            var files = HttpContext.Request.Form.Files;
            foreach (var Image in files)
            {
                // only save images in input name [files-entity]
                if (Image != null && Image.Length > 0 && Image.Name == "files-entity")
                {
                    var file = Image;
                    //There is an error here

                    if (file.Length > 0)
                    {
                        var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                        using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                        {
                            file.CopyToAsync(fileStream);
                            //emp.BookPic = fileName;
                            images.Add(new Image
                            {
                                Path = mapFolder + "\\",
                                FileName = fileName,
                                OrginalName = file.FileName
                            });
                        }
                    }
                }
            }
            #endregion

            var categoryCode = viewModel.Entities.First(m => m.Language.Equals(Constants.Languages.Vietnamese)).CategoryCode;
            foreach (var entity in viewModel.Entities)
            {
                entity.Code = newCode;
                entity.CategoryCode = categoryCode;
                entity.Images = images;
                if (!string.IsNullOrEmpty(entity.Name))
                {
                    entity.Alias = Utility.AliasConvert(entity.Name);
                }

                dbContext.ProductSales.InsertOne(entity);
            }

            #region Update Language Entity if null [Vietnamese always have data]
            var viEntity = dbContext.ProductSales.Find(m => m.Code.Equals(newCode) && m.Language.Equals(Constants.Languages.Vietnamese)).First();
            foreach (var languageEntity in dbContext.ProductSales.Find(m => m.Code.Equals(newCode) && !m.Language.Equals(Constants.Languages.Vietnamese)).ToList())
            {
                if (string.IsNullOrEmpty(languageEntity.Name))
                {
                    var translateName = Utility.TranslateText(viEntity.Name, languageEntity.Language);
                    var translateDescription = Utility.TranslateText(viEntity.Description, languageEntity.Language);

                    var filter = Builders<ProductSale>.Filter.Eq(m => m.Id, languageEntity.Id);
                    var update = Builders<ProductSale>.Update
                        .Set(m => m.Name, translateName)
                        .Set(m => m.Description, translateDescription)
                        .Set(m => m.Alias, Utility.AliasConvert(translateName));

                    dbContext.ProductSales.UpdateOne(filter, update);
                }
            }
            #endregion

            return RedirectToAction("ProductCreate");
        }

        [Route("/core/product/edit/{code}")]
        public IActionResult ProductEdit(int code)
        {
            #region Language
            var cultureInfo = new CultureInfo("vi-VN");
            ViewData["Language"] = cultureInfo.Name;
            ViewData["LanguageHtmlTag"] = cultureInfo.TwoLetterISOLanguageName;
            #endregion

            #region Dropdownlist
            var languages = dbContext.Languages.Find(m => m.Enable.Equals(true) && !m.Code.Equals(cultureInfo.TwoLetterISOLanguageName));
            ViewData["Languages"] = languages.ToList();

            var categories = dbContext.ProductCategorySales.Find(m => m.Language.Equals(cultureInfo.Name) && m.ParentCode.Equals(1));
            ViewData["Categories"] = categories.ToList();
            #endregion

            var entities = dbContext.ProductSales.Find(m => m.Enable.Equals(true) && m.Code.Equals(code)).ToList();
            var viewModel = new ProductDataViewModel()
            {
                Entities = entities,
                Code = code
            };
            return View(viewModel);
        }

        [HttpPost]
        [Route("/core/product/edit/{code}")]
        public IActionResult ProductEdit(ProductDataViewModel viewModel, int code)
        {
            #region Language
            var cultureInfo = new CultureInfo("en-US");
            ViewData["Language"] = cultureInfo.Name;
            ViewData["LanguageHtmlTag"] = cultureInfo.TwoLetterISOLanguageName;
            #endregion

            #region Images, each product 1 folder. (return images)
            var images = dbContext.ProductSales.Find(m => m.Code.Equals(code)).First().Images;
            if (images == null)
            {
                images = new List<Image>();
            }
            var mapFolder = "images\\" + Constants.Link.Product + "\\" + code;
            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, mapFolder);
            if (!Directory.Exists(uploads))
            {
                Directory.CreateDirectory(uploads);
            }

            var files = HttpContext.Request.Form.Files;
            foreach (var Image in files)
            {
                if (Image != null && Image.Length > 0 && Image.Name == "files-entity")
                {
                    var file = Image;
                    //There is an error here
                    if (file.Length > 0)
                    {
                        var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                        using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                        {
                            file.CopyToAsync(fileStream);
                            //emp.BookPic = fileName;
                            images.Add(new Image
                            {
                                Path = mapFolder + "\\",
                                FileName = fileName,
                                OrginalName = file.FileName
                            });
                        }
                    }
                }
            }

            if (images.Count == 0)
            {
                images = null;
            }
            #endregion

            var categoryCode = viewModel.Entities.First(m => m.Language.Equals(Constants.Languages.Vietnamese)).CategoryCode;
            foreach (var entity in viewModel.Entities)
            {
                entity.CategoryCode = categoryCode;
                entity.Images = images;

                if (!string.IsNullOrEmpty(entity.Name))
                {
                    entity.Alias = Utility.AliasConvert(entity.Name);
                }
                // if existing => update
                // else more language, create new
                //bool exists = dbContext.ProductSales.Find(m => m.Id.Equals(entity.Id)).Any();
                // For faster. No call data. check data
                if (!string.IsNullOrEmpty(entity.Id))
                {
                    var filter = Builders<ProductSale>.Filter.Eq(m => m.Id, entity.Id);
                    var update = Builders<ProductSale>.Update
                        .Set(m => m.CategoryCode, entity.CategoryCode)
                        .Set(m => m.Name, entity.Name)
                        .Set(m => m.Alias, entity.Alias)
                        .Set(m => m.Price, entity.Price)
                        .Set(m => m.Description, entity.Description)
                        .Set(m => m.Content, entity.Content)
                        .Set(m => m.Images, entity.Images);
                    var resultKho = dbContext.ProductSales.UpdateOne(filter, update);
                }
                else
                {
                    entity.Code = code;
                    entity.Images = images;
                    dbContext.ProductSales.InsertOne(entity);
                }
            }

            #region Update Language Entity if null [Vietnamese always have data]
            var viEntity = dbContext.ProductSales.Find(m => m.Code.Equals(code) && m.Language.Equals(Constants.Languages.Vietnamese)).First();
            foreach (var languageEntity in dbContext.ProductSales.Find(m => m.Code.Equals(code) && !m.Language.Equals(Constants.Languages.Vietnamese)).ToList())
            {
                if (string.IsNullOrEmpty(languageEntity.Name))
                {
                    var translateName = Utility.TranslateText(viEntity.Name, languageEntity.Language);
                    var translateDescription = Utility.TranslateText(viEntity.Description, languageEntity.Language);

                    var filter = Builders<ProductSale>.Filter.Eq(m => m.Id, languageEntity.Id);
                    var update = Builders<ProductSale>.Update
                        .Set(m => m.Name, translateName)
                        .Set(m => m.Description, translateDescription)
                        .Set(m => m.Alias, Utility.AliasConvert(translateName));

                    dbContext.ProductSales.UpdateOne(filter, update);
                }
            }
            #endregion

            return RedirectToAction("ProductEdit", code);
        }

        [Route("/core/product/delete/{code}")]
        public IActionResult ProductDelete(int code)
        {
            #region Language
            var cultureInfo = new CultureInfo("vi-VN");
            ViewData["Language"] = cultureInfo.Name;
            ViewData["LanguageHtmlTag"] = cultureInfo.TwoLetterISOLanguageName;
            #endregion

            #region Dropdownlist
            var categories = dbContext.ProductCategorySales.Find(m => m.Language.Equals(cultureInfo.Name) && m.ParentCode.Equals(1));
            ViewData["Categories"] = categories.ToList();
            #endregion

            var entity = dbContext.ProductSales.Find(m => m.Code.Equals(code)).First();

            return View(entity);
        }

        [HttpPost]
        [Route("/core/product/delete/{code}")]
        public IActionResult ProductDelete(ProductSale entity, int code)
        {
            var filter = Builders<ProductSale>.Filter.Eq(m => m.Code, code);
            var update = Builders<ProductSale>.Update
                .Set(m => m.Enable, false);
            var resultKho = dbContext.ProductSales.UpdateOne(filter, update);

            //dbContext.ProductSales.DeleteOne(
            //                Builders<ProductKinhDoanh>.Filter.Eq("Id", id));

            return RedirectToAction("Product");
        }


        [Route("/core/news/")]
        public IActionResult News()
        {
            #region Language
            var cultureInfo = new CultureInfo("vi-VN");
            ViewData["Language"] = cultureInfo.Name;
            ViewData["LanguageHtmlTag"] = cultureInfo.TwoLetterISOLanguageName;
            #endregion

            #region Dropdownlist
            var categories = dbContext.NewsCategories.Find(m => m.Language.Equals(cultureInfo.Name));
            ViewData["Categories"] = categories.ToList();
            #endregion

            var list = dbContext.News.Find(m => true).ToList();
            return View(list);
        }

        [Route("/core/news/create")]
        public IActionResult NewsCreate()
        {
            #region Language
            var cultureInfo = new CultureInfo("vi-VN");
            ViewData["Language"] = cultureInfo.Name;
            ViewData["LanguageHtmlTag"] = cultureInfo.TwoLetterISOLanguageName;
            #endregion

            #region Dropdownlist
            var categories = dbContext.NewsCategories.Find(m => m.Language.Equals(cultureInfo.Name));
            ViewData["Categories"] = categories.ToList();
            #endregion
            return View();
        }

        [HttpPost]
        [Route("/core/news/create/")]
        public IActionResult NewsCreate(News entity)
        {
            #region Language
            var cultureInfo = new CultureInfo("en-US");
            ViewData["Language"] = cultureInfo.Name;
            ViewData["LanguageHtmlTag"] = cultureInfo.TwoLetterISOLanguageName;
            #endregion

            #region System autofill
            var newCode = 1;
            var sort = Builders<News>.Sort.Descending("Code");
            var filter1 = Builders<News>.Filter.Empty;
            var lastRecords = dbContext.News.Find(filter1).Sort(sort).Limit(1);
            if (lastRecords != null)
            {
                newCode = lastRecords.First().Code + 1;
            }

            entity.Code = newCode;
            entity.Alias = Utility.AliasConvert(entity.Name);
            entity.Language = Constants.Languages.Vietnamese;
            var category = dbContext.ProductCategorySales.Find(m => m.Code.Equals(entity.CategoryCode) && m.Language.Equals(entity.Language)).First();

            #endregion

            #region Images, each product 1 folder.
            var images = new List<Image>();
            var mapFolder = "images\\" + Constants.Link.News + "\\" + newCode;
            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, mapFolder);
            if (!Directory.Exists(uploads))
            {
                Directory.CreateDirectory(uploads);
            }

            var files = HttpContext.Request.Form.Files;
            foreach (var Image in files)
            {
                if (Image != null && Image.Length > 0)
                {
                    var file = Image;
                    //There is an error here

                    if (file.Length > 0)
                    {
                        var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                        using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                        {
                            file.CopyToAsync(fileStream);
                            //emp.BookPic = fileName;
                            images.Add(new Image
                            {
                                Path = mapFolder,
                                FileName = fileName,
                            });
                        }
                    }
                }
            }

            entity.Images = images;
            #endregion

            dbContext.News.InsertOne(entity);
            return RedirectToAction("NewsCreate");
        }

        [Route("/core/news/edit/{id}")]
        public IActionResult NewsEdit(string id)
        {
            #region Language
            var cultureInfo = new CultureInfo("vi-VN");
            ViewData["Language"] = cultureInfo.Name;
            ViewData["LanguageHtmlTag"] = cultureInfo.TwoLetterISOLanguageName;
            #endregion

            #region Dropdownlist
            var categories = dbContext.NewsCategories.Find(m => m.Language.Equals(cultureInfo.Name));
            ViewData["Categories"] = categories.ToList();
            #endregion

            var entity = dbContext.News.Find(m => m.Id.Equals(id)).First();

            return View(entity);
        }

        [HttpPost]
        [Route("/core/news/edit/{id}")]
        public IActionResult NewsEdit(News entity, string id)
        {
            #region Language
            var cultureInfo = new CultureInfo("en-US");
            ViewData["Language"] = cultureInfo.Name;
            ViewData["LanguageHtmlTag"] = cultureInfo.TwoLetterISOLanguageName;
            #endregion

            #region System autofill
            entity.Alias = Utility.AliasConvert(entity.Name);
            entity.Language = Constants.Languages.Vietnamese;
            var category = dbContext.NewsCategories.Find(m => m.Code.Equals(entity.CategoryCode)).First();

            #endregion

            #region Images, each product 1 folder.
            var images = dbContext.News.Find(m => m.Id.Equals(id)).First().Images;
            if (images == null)
            {
                images = new List<Image>();
            }
            //var images = new List<ProductImg>();
            var mapFolder = "images\\" + Constants.Link.News + "\\" + entity.Code;
            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, mapFolder);
            if (!Directory.Exists(uploads))
            {
                Directory.CreateDirectory(uploads);
            }

            var files = HttpContext.Request.Form.Files;
            foreach (var Image in files)
            {
                if (Image != null && Image.Length > 0)
                {
                    var file = Image;
                    //There is an error here

                    if (file.Length > 0)
                    {
                        var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                        using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                        {
                            file.CopyToAsync(fileStream);
                            //emp.BookPic = fileName;
                            images.Add(new Image
                            {
                                Path = mapFolder,
                                FileName = fileName,
                            });
                        }
                    }
                }
            }

            if (images.Count == 0)
            {
                images = null;
            }
            entity.Images = images;
            #endregion

            //dbContext.ProductSales.UpdateOne(entity);
            var filter = Builders<News>.Filter.Eq(m => m.Id, id);
            var update = Builders<News>.Update
                .Set(m => m.CategoryCode, entity.CategoryCode)
                .Set(m => m.Name, entity.Name)
                .Set(m => m.Alias, entity.Alias)
                .Set(m => m.Description, entity.Description)
                .Set(m => m.Content, entity.Content)
                .Set(m => m.Images, entity.Images);
            var resultKho = dbContext.News.UpdateOne(filter, update);

            return RedirectToPage("/core/news/edit/{0}", entity.Id);
        }

        [Route("/core/job/")]
        public IActionResult Job()
        {
            #region Language
            var cultureInfo = new CultureInfo("vi-VN");
            ViewData["Language"] = cultureInfo.Name;
            ViewData["LanguageHtmlTag"] = cultureInfo.TwoLetterISOLanguageName;
            #endregion

            #region Dropdownlist
            var categories = dbContext.JobCategories.Find(m => m.Language.Equals(cultureInfo.Name));
            ViewData["Categories"] = categories.ToList();

            var departments = dbContext.Departments.Find(m => m.Language.Equals(cultureInfo.Name));
            ViewData["Departments"] = departments.ToList();
            #endregion

            var list = dbContext.Jobs.Find(m => true).ToList();
            return View(list);
        }

        [Route("/core/job/create")]
        public IActionResult JobCreate()
        {
            #region Language
            var cultureInfo = new CultureInfo("vi-VN");
            ViewData["Language"] = cultureInfo.Name;
            ViewData["LanguageHtmlTag"] = cultureInfo.TwoLetterISOLanguageName;
            #endregion

            #region Dropdownlist
            var categories = dbContext.JobCategories.Find(m => m.Language.Equals(cultureInfo.Name));
            ViewData["Categories"] = categories.ToList();

            var departments = dbContext.Departments.Find(m => m.Language.Equals(cultureInfo.Name));
            ViewData["Departments"] = departments.ToList();
            #endregion

            return View();
        }

        [HttpPost]
        [Route("/core/job/create/")]
        public IActionResult JobCreate(Job entity)
        {
            #region Language
            var cultureInfo = new CultureInfo("en-US");
            ViewData["Language"] = cultureInfo.Name;
            ViewData["LanguageHtmlTag"] = cultureInfo.TwoLetterISOLanguageName;
            #endregion

            #region System autofill
            var newCode = 1;
            var sort = Builders<Job>.Sort.Descending("Code");
            var filter1 = Builders<Job>.Filter.Empty;
            var lastRecords = dbContext.Jobs.Find(filter1).Sort(sort).Limit(1);
            if (lastRecords != null)
            {
                newCode = lastRecords.First().Code + 1;
            }

            entity.Code = newCode;
            entity.Alias = Utility.AliasConvert(entity.Name);
            entity.Language = Constants.Languages.Vietnamese;
            var category = dbContext.JobCategories.Find(m => m.Code.Equals(entity.CategoryCode) && m.Language.Equals(entity.Language)).First();

            #endregion

            #region Images, each product 1 folder.
            var images = new List<Image>();
            var mapFolder = "images\\" + Constants.Link.Job + "\\" + newCode;
            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, mapFolder);
            if (!Directory.Exists(uploads))
            {
                Directory.CreateDirectory(uploads);
            }

            var files = HttpContext.Request.Form.Files;
            foreach (var Image in files)
            {
                if (Image != null && Image.Length > 0)
                {
                    var file = Image;
                    //There is an error here

                    if (file.Length > 0)
                    {
                        var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                        using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                        {
                            file.CopyToAsync(fileStream);
                            //emp.BookPic = fileName;
                            images.Add(new Image
                            {
                                Path = mapFolder,
                                FileName = fileName,
                            });
                        }
                    }
                }
            }

            entity.Images = images;
            #endregion

            dbContext.Jobs.InsertOne(entity);
            return RedirectToAction("JobCreate");
        }

        [Route("/core/job/edit/{id}")]
        public IActionResult JobEdit(string id)
        {
            #region Language
            var cultureInfo = new CultureInfo("vi-VN");
            ViewData["Language"] = cultureInfo.Name;
            ViewData["LanguageHtmlTag"] = cultureInfo.TwoLetterISOLanguageName;
            #endregion

            #region Dropdownlist
            var categories = dbContext.JobCategories.Find(m => m.Language.Equals(cultureInfo.Name));
            ViewData["Categories"] = categories.ToList();

            var departments = dbContext.Departments.Find(m => m.Language.Equals(cultureInfo.Name));
            ViewData["Departments"] = departments.ToList();
            #endregion

            var entity = dbContext.Jobs.Find(m => m.Id.Equals(id)).First();

            return View(entity);
        }

        [HttpPost]
        [Route("/core/job/edit/{id}")]
        public IActionResult JobEdit(Job entity, string id)
        {
            #region Language
            var cultureInfo = new CultureInfo("en-US");
            ViewData["Language"] = cultureInfo.Name;
            ViewData["LanguageHtmlTag"] = cultureInfo.TwoLetterISOLanguageName;
            #endregion

            #region System autofill
            entity.Alias = Utility.AliasConvert(entity.Name);
            entity.Language = Constants.Languages.Vietnamese;
            var category = dbContext.JobCategories.Find(m => m.Code.Equals(entity.CategoryCode)).First();

            #endregion

            #region Images, each product 1 folder.
            var images = dbContext.Jobs.Find(m => m.Id.Equals(id)).First().Images;
            if (images == null)
            {
                images = new List<Image>();
            }
            //var images = new List<ProductImg>();
            var mapFolder = "images\\" + Constants.Link.Job + "\\" + entity.Code;
            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, mapFolder);
            if (!Directory.Exists(uploads))
            {
                Directory.CreateDirectory(uploads);
            }

            var files = HttpContext.Request.Form.Files;
            foreach (var Image in files)
            {
                if (Image != null && Image.Length > 0)
                {
                    var file = Image;
                    //There is an error here

                    if (file.Length > 0)
                    {
                        var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                        using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                        {
                            file.CopyToAsync(fileStream);
                            //emp.BookPic = fileName;
                            images.Add(new Image
                            {
                                Path = mapFolder,
                                FileName = fileName,
                            });
                        }
                    }
                }
            }

            if (images.Count == 0)
            {
                images = null;
            }
            entity.Images = images;
            #endregion

            //dbContext.ProductSales.UpdateOne(entity);
            var filter = Builders<Job>.Filter.Eq(m => m.Id, id);
            var update = Builders<Job>.Update
                .Set(m => m.CategoryCode, entity.CategoryCode)
                .Set(m => m.Name, entity.Name)
                .Set(m => m.Alias, entity.Alias)
                .Set(m => m.Description, entity.Description)
                .Set(m => m.Content, entity.Content)
                .Set(m => m.Images, entity.Images);
            var resultKho = dbContext.Jobs.UpdateOne(filter, update);

            return RedirectToPage("/core/job/edit/{0}", entity.Id);
        }

        [Route("/core/content")]
        public IActionResult Content()
        {
            #region Language
            var cultureInfo = new CultureInfo("vi-VN");
            ViewData["Language"] = cultureInfo.Name;
            ViewData["LanguageHtmlTag"] = cultureInfo.TwoLetterISOLanguageName;
            #endregion

            #region Dropdownlist
            //var categories = dbContext.Contents.Find(m => m.Language.Equals(cultureInfo.Name));
            //ViewData["Categories"] = categories.ToList();
            #endregion

            var list = dbContext.Contents.Find(m => m.Enable.Equals(true) && m.Language.Equals(Constants.Languages.Vietnamese)).ToList();
            return View(list);
        }

        [Route("/core/content/edit/{code}")]
        public IActionResult ContentEdit(string code)
        {
            #region Language
            var cultureInfo = new CultureInfo("vi-VN");
            ViewData["Language"] = cultureInfo.Name;
            ViewData["LanguageHtmlTag"] = cultureInfo.TwoLetterISOLanguageName;
            #endregion

            #region Dropdownlist
            var languages = dbContext.Languages.Find(m => m.Enable.Equals(true) && !m.Code.Equals(cultureInfo.TwoLetterISOLanguageName));
            ViewData["Languages"] = languages.ToList();

            //var categories = dbContext.ProductCategorySales.Find(m => m.Language.Equals(cultureInfo.Name) && m.ParentCode.Equals(1));
            //ViewData["Categories"] = categories.ToList();
            #endregion

            var entities = dbContext.Contents.Find(m => m.Enable.Equals(true) && m.Code.Equals(code)).ToList();
            var viewModel = new ContentDataViewModel()
            {
                Entities = entities,
                Code = code
            };
            return View(viewModel);
        }

        [HttpPost]
        [Route("/core/content/edit/{code}")]
        public IActionResult ContentEdit(ContentDataViewModel viewModel, string code)
        {
            #region Language
            var cultureInfo = new CultureInfo("en-US");
            ViewData["Language"] = cultureInfo.Name;
            ViewData["LanguageHtmlTag"] = cultureInfo.TwoLetterISOLanguageName;
            #endregion

            #region Images, each product 1 folder. (return images)
            var images = dbContext.Contents.Find(m => m.Code.Equals(code)).First().Images;
            if (images == null)
            {
                images = new List<Image>();
            }
            var mapFolder = "images\\" + Constants.Link.Content + "\\" + code;
            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, mapFolder);
            if (!Directory.Exists(uploads))
            {
                Directory.CreateDirectory(uploads);
            }

            var files = HttpContext.Request.Form.Files;
            foreach (var Image in files)
            {
                if (Image != null && Image.Length > 0 && Image.Name == "files-entity")
                {
                    var file = Image;
                    //There is an error here
                    if (file.Length > 0)
                    {
                        var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                        using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                        {
                            file.CopyToAsync(fileStream);
                            //emp.BookPic = fileName;
                            images.Add(new Image
                            {
                                Path = mapFolder + "\\",
                                FileName = fileName,
                                OrginalName = file.FileName
                            });
                        }
                    }
                }
            }

            if (images.Count == 0)
            {
                images = null;
            }
            #endregion

            //var categoryCode = viewModel.Entities.First(m => m.Language.Equals(Constants.Languages.Vietnamese)).CategoryCode;
            foreach (var entity in viewModel.Entities)
            {
                //entity.CategoryCode = categoryCode;
                entity.Images = images;

                if (!string.IsNullOrEmpty(entity.Title))
                {
                    entity.Alias = Utility.AliasConvert(entity.Title);
                }
                // if existing => update
                // else more language, create new
                //bool exists = dbContext.ProductSales.Find(m => m.Id.Equals(entity.Id)).Any();
                // For faster. No call data. check data
                if (!string.IsNullOrEmpty(entity.Id))
                {
                    var filter = Builders<Content>.Filter.Eq(m => m.Id, entity.Id);
                    var update = Builders<Content>.Update
                        //.Set(m => m.CategoryCode, entity.CategoryCode)
                        .Set(m => m.Title, entity.Title)
                        .Set(m => m.Alias, entity.Alias)
                        .Set(m => m.Description, entity.Description)
                        .Set(m => m.Body, entity.Body)
                        .Set(m => m.Images, entity.Images);
                    var resultKho = dbContext.Contents.UpdateOne(filter, update);
                }
                else
                {
                    entity.Code = code;
                    entity.Images = images;
                    dbContext.Contents.InsertOne(entity);
                }
            }

            #region Update Language Entity if null [Vietnamese always have data]
            var viEntity = dbContext.Contents.Find(m => m.Code.Equals(code) && m.Language.Equals(Constants.Languages.Vietnamese)).First();
            foreach (var languageEntity in dbContext.Contents.Find(m => m.Code.Equals(code) && !m.Language.Equals(Constants.Languages.Vietnamese)).ToList())
            {
                if (string.IsNullOrEmpty(languageEntity.Name))
                {
                    var translateName = Utility.TranslateText(viEntity.Title, languageEntity.Language);
                    var translateDescription = Utility.TranslateText(viEntity.Description, languageEntity.Language);

                    var filter = Builders<Content>.Filter.Eq(m => m.Id, languageEntity.Id);
                    var update = Builders<Content>.Update
                        .Set(m => m.Title, translateName)
                        .Set(m => m.Description, translateDescription)
                        .Set(m => m.Alias, Utility.AliasConvert(translateName));

                    dbContext.Contents.UpdateOne(filter, update);
                }
            }
            #endregion

            return RedirectToAction("ContentEdit", code);
        }

        [Route("/core/content/delete/{code}")]
        public IActionResult ContentDelete(string code)
        {
            #region Language
            var cultureInfo = new CultureInfo("vi-VN");
            ViewData["Language"] = cultureInfo.Name;
            ViewData["LanguageHtmlTag"] = cultureInfo.TwoLetterISOLanguageName;
            #endregion

            #region Dropdownlist
            //var categories = dbContext.ProductCategorySales.Find(m => m.Language.Equals(cultureInfo.Name) && m.ParentCode.Equals(1));
            //ViewData["Categories"] = categories.ToList();
            #endregion

            var entity = dbContext.Contents.Find(m => m.Code.Equals(code)).First();

            return View(entity);
        }

        [HttpPost]
        [Route("/core/content/delete/{code}")]
        public IActionResult ContentDelete(Content entity, string code)
        {
            var filter = Builders<Content>.Filter.Eq(m => m.Code, code);
            var update = Builders<Content>.Update
                .Set(m => m.Enable, false);
            var resultKho = dbContext.Contents.UpdateOne(filter, update);

            return RedirectToAction("Content");
        }


        [Route("/api/translate/{language}/{text}")]
        public JsonResult TranslateText(string language, string text)
        {
            var result = Utility.TranslateText(text, language);
            return Json(result);
        }

    }
}