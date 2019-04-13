﻿using Common.Enums;
using Common.Utilities;
using Data;
using Models;
using ViewModels;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Configuration;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.Util;
using MimeKit;
using MimeKit.Text;


namespace xmailtimer
{
    class Program
    {
        static void Main(string[] args)
        {
            #region setting
            var location = ConfigurationSettings.AppSettings.Get("location").ToString();
            var modeData = ConfigurationSettings.AppSettings.Get("modeData").ToString() == "1" ? true : false; // true: Get all data | false get by date
            var day = Convert.ToInt32(ConfigurationSettings.AppSettings.Get("day").ToString());
            var isMail = ConfigurationSettings.AppSettings.Get("isMail").ToString() == "1" ? true : false;
            var debug = ConfigurationSettings.AppSettings.Get("debug").ToString() == "1" ? true : false;
            var connection = "mongodb://localhost:27017";
            var database = "tribat";
            #endregion

            SendTimeKeeper(location, modeData, day, isMail, connection, database, debug);
        }

        static void SendTimeKeeper(string location, bool modeData, int day, bool isMail, string connection, string database, bool debug)
        {
            #region Connection, Setting & Filter
            MongoDBContext.ConnectionString = connection;
            MongoDBContext.DatabaseName = database;
            MongoDBContext.IsSSL = true;
            MongoDBContext dbContext = new MongoDBContext();
            var url = Constants.System.domain;
            #endregion

            #region DDL
            var congtychinhanhs = dbContext.CongTyChiNhanhs.Find(m => m.Enable.Equals(true)).ToList();
            var congtychinhanhTruSo = congtychinhanhs.Where(m => m.Code.Equals("CT1")).FirstOrDefault();
            var congtychinhanhNhaMay = congtychinhanhs.Where(m => m.Code.Equals("CT2")).FirstOrDefault();
            var khoichucnangs = dbContext.KhoiChucNangs.Find(m => m.Enable.Equals(true)).ToList();
            var phongbans = dbContext.PhongBans.Find(m => m.Enable.Equals(true)).ToList();
            var bophans = dbContext.BoPhans.Find(m => m.Enable.Equals(true) && string.IsNullOrEmpty(m.Parent)).ToList();
            var chucvus = dbContext.ChucVus.Find(m => m.Enable.Equals(true)).ToList();
            #endregion

            #region Times : 26 run
            var today = DateTime.Now;
            var ngaychot = new DateTime(today.Year, today.Month, 26);
            var Tu = new DateTime(ngaychot.AddMonths(-1).Year, ngaychot.AddMonths(-1).Month, 26);
            var Den = ngaychot.AddDays(-1);
            #endregion

            #region Filter
            var builder = Builders<Employee>.Filter;
            var filter = !builder.Eq(i => i.UserName, Constants.System.account)
                        & builder.Eq(m => m.CongTyChiNhanh, congtychinhanhNhaMay.Id)
                        & builder.Eq(m => m.Enable, true)
                        & builder.Eq(m => m.Leave, false);

            if (debug)
            {
                var debugString = ConfigurationSettings.AppSettings.Get("debugString").ToString();
                filter = filter & builder.Eq(m => m.Id, debugString);
            }

            var fields = Builders<Employee>.Projection.Include(p => p.Id);

            //var employeeFilters1 = dbContext.Employees.Find(filter).ToList();
            //var employeeIds1 = dbContext.Employees.Find(filter).Project<Employee>(fields).ToList().Select(m => m.Id).ToList();

            // NHA MAY: + Phong XDCB + Phong Du An, Vat Tu, TTNC, NCUD
            var listPhongBanTinhCongONhaMay = new List<string>
            {
                "5c88d094d59d56225c43242a", // XDCB
                "5c88d094d59d56225c432437", // DA
                "5c88d094d59d56225c43242f", // VATTU
                "5c88d094d59d56225c432435", // BAN VAT TU
                "5c88d094d59d56225c43243c", // TTNC
                "5c88d094d59d56225c432441" // NCUD
            };
            var listPrevent = new List<string>
            {
                "5b6bb22fe73a301f941c589e", // Huyen
                "5bc048540ae7341a7ce7f1fb" // Hien
            };
            // Add HCNS: Thy, Thoa, Xuan, Phuong
            //var listEmpHCNSONhaMay = new List<string>
            //{
            //    "5b6bb22fe73a301f941c5885",
            //    "5b6bb231e73a301f941c58dd",
            //    "5b6bfc463ee8461ee48cbbea",
            //    "5c3e90b5566d7c0a345e5488"
            //};
            // UAT
            var listEmpHCNSONhaMay = new List<string>
            {
                "5b6bb232e73a301f941c592f"
            };
            var employeeXDCBDuAn = dbContext.Employees.Find(m => m.Enable.Equals(true) && m.Leave.Equals(false) && listPhongBanTinhCongONhaMay.Contains(m.PhongBan) && !listPrevent.Contains(m.Id)).ToList();
            var employeeXDCBDuAnIds = dbContext.Employees.Find(m => m.Enable.Equals(true) && m.Leave.Equals(false) && listPhongBanTinhCongONhaMay.Contains(m.PhongBan) && !listPrevent.Contains(m.Id)).ToList().Select(m => m.Id).ToList();
            var employeeHCNSNMs = dbContext.Employees.Find(m => m.Enable.Equals(true) && m.Leave.Equals(false) && listEmpHCNSONhaMay.Contains(m.Id)).ToList();
            var employeeHCNSNMIds = dbContext.Employees.Find(m => m.Enable.Equals(true) && m.Leave.Equals(false) && listEmpHCNSONhaMay.Contains(m.Id)).ToList().Select(m => m.Id).ToList();

            //var employeeFilters = employeeFilters1.Concat(employeeXDCBDuAn).Concat(employeeHCNSNMs).ToList();
            //var employeeIds = employeeIds1.Concat(employeeXDCBDuAnIds).Concat(employeeHCNSNMIds).ToList();

            //var employeeFilters = employeeXDCBDuAn.Concat(employeeHCNSNMs).ToList();
            //var employeeIds = employeeXDCBDuAnIds.Concat(employeeHCNSNMIds).ToList();
            var employeeFilters = employeeHCNSNMs;
            var employeeIds = employeeHCNSNMIds;

            var builderT = Builders<EmployeeWorkTimeLog>.Filter;
            var filterT = builderT.Eq(m => m.Enable, true)
                        & builderT.Gte(m => m.Date, Tu)
                        & builderT.Lte(m => m.Date, Den);
            if (employeeIds != null && employeeIds.Count > 0)
            {
                filterT = filterT & builderT.Where(m => employeeIds.Contains(m.EmployeeId));
            }
            #endregion

            var times = dbContext.EmployeeWorkTimeLogs.Find(filterT).SortBy(m => m.Date).ToList();
            var results = new List<TimeKeeperDisplay>();

            #region method 1: base employee
            foreach (var employee in employeeFilters)
            {
                var employeeWorkTimeLogs = times.Where(m => m.EmployeeId.Equals(employee.Id)).ToList();
                if (employeeWorkTimeLogs == null || employeeWorkTimeLogs.Count == 0) continue;

                var enrollNumber = string.Empty;
                var congtychinhanhName = string.Empty;
                var khoichucnangName = string.Empty;
                var phongbanName = string.Empty;
                var bophanName = string.Empty;
                var bophanConName = string.Empty;
                var chucvuName = string.Empty;

                enrollNumber = employeeWorkTimeLogs[0].EnrollNumber;

                if (!string.IsNullOrEmpty(employee.CongTyChiNhanh))
                {
                    var ctcnE = congtychinhanhs.Where(m => m.Id.Equals(employee.CongTyChiNhanh)).FirstOrDefault();
                    if (ctcnE != null)
                    {
                        congtychinhanhName = ctcnE.Name;
                    }
                }
                if (!string.IsNullOrEmpty(employee.KhoiChucNang))
                {
                    var kcnE = khoichucnangs.Where(m => m.Id.Equals(employee.KhoiChucNang)).FirstOrDefault();
                    if (kcnE != null)
                    {
                        khoichucnangName = kcnE.Name;
                    }
                }
                if (!string.IsNullOrEmpty(employee.PhongBan))
                {
                    var pbE = phongbans.Where(m => m.Id.Equals(employee.PhongBan)).FirstOrDefault();
                    if (pbE != null)
                    {
                        phongbanName = pbE.Name;
                    }
                }
                if (!string.IsNullOrEmpty(employee.BoPhan))
                {
                    var bpE = bophans.Where(m => m.Id.Equals(employee.BoPhan)).FirstOrDefault();
                    if (bpE != null)
                    {
                        bophanName = bpE.Name;
                    }
                }
                if (!string.IsNullOrEmpty(employee.ChucVu))
                {
                    var cvE = chucvus.Where(m => m.Id.Equals(employee.ChucVu)).FirstOrDefault();
                    if (cvE != null)
                    {
                        chucvuName = cvE.Name;
                    }
                }

                var employeeDisplay = new TimeKeeperDisplay()
                {
                    EmployeeWorkTimeLogs = employeeWorkTimeLogs,
                    Id = employee.Id,
                    Code = employee.Code + "(" + employee.CodeOld + ")",
                    EnrollNumber = enrollNumber,
                    FullName = employee.FullName,
                    CongTyChiNhanh = congtychinhanhName,
                    KhoiChucNang = khoichucnangName,
                    PhongBan = phongbanName,
                    BoPhan = bophanName,
                    ChucVu = chucvuName,
                    Alias = employee.AliasFullName,
                    Email = employee.Email,
                    ManageId = employee.ManagerId
                };
                results.Add(employeeDisplay);
            }

            // UAT : Check data
            var nhamayCount = results.Count(m => m.CongTyChiNhanh.Equals("Nhà máy Xử lý bùn thải Sài Gòn Xanh"));
            #endregion

            #region Get Hrs: For case empty Email of user and manager
            var hrsCongTy = new List<Employee>();
            var hrsNhaMay = new List<Employee>();

            var listHrRoles = dbContext.RoleUsers.Find(m => m.Role.Equals(Constants.Rights.NhanSu) && (m.Expired.Equals(null) || m.Expired > DateTime.Now)).ToList();
            if (listHrRoles != null && listHrRoles.Count > 0)
            {
                foreach (var item in listHrRoles)
                {
                    if (item.Action == 3)
                    {
                        var fieldHrs = Builders<Employee>.Projection.Include(p => p.Email).Include(p => p.FullName).Include(p => p.CongTyChiNhanh);
                        var employeeHr = dbContext.Employees.Find(m => m.Id.Equals(item.User) && !string.IsNullOrEmpty(m.Email)).Project<Employee>(fieldHrs).FirstOrDefault();
                        if (employeeHr != null)
                        {
                            // Because data not good, set hand
                            if (employeeHr.Id == "5b6bb22fe73a301f941c5887")
                            {
                                hrsCongTy.Add(employeeHr);
                            }
                            else if (employeeHr.Id == "5b6bb231e73a301f941c58dd")
                            {
                                hrsNhaMay.Add(employeeHr);
                            }
                        }
                    }
                }
            }
            #endregion

            int thang = ngaychot.Month;
            int nam = ngaychot.Year;
            var subject = string.Empty;
            var note = string.Empty;
            var owner = string.Empty;
            var to2 = string.Empty;

            #region Step 1: Employee have email
            var listFull = results.Where(m => !string.IsNullOrEmpty(m.Email)).ToList();
            foreach (var employee in listFull)
            {
                string sFileName = @"bang-cham-cong";
                sFileName += "-" + thang + "-" + nam;
                sFileName += "-" + employee.Alias + ".xlsx";

                var timers = employee.EmployeeWorkTimeLogs;
                if (timers == null || timers.Count == 0) continue;

                var displayItem = new List<TimeKeeperDisplay> { employee };
                var excelViewModel = RenderExcel(Tu, Den, ngaychot, sFileName, 1, displayItem);

                #region SCHEDULE MAIL
                Console.WriteLine("Send email to:" + employee.Email);
                subject = "CHẤM CÔNG THÁNG " + thang + "-" + nam;
                note = string.Empty;
                owner = string.Empty;
                to2 = employee.FullName;
                var tos = new List<EmailAddress>
                {
                    new EmailAddress { Name = employee.FullName, Address = employee.Email }
                };

                if (excelViewModel.NgayCongNT == 0)
                {
                    // Because some case have enrollNumber but no time manage.
                    // If ngaycongNT = 0: gui thoa
                    subject = "CHẤM CÔNG THÁNG " + thang + "-" + nam + " của " + employee.FullName.ToUpper();
                    to2 = "Cao Thị Minh Thoa";
                    owner = " của " + employee.FullName;
                    tos = new List<EmailAddress>
                    {
                        new EmailAddress { Name = "Cao Thị Minh Thoa", Address = "thoa.ctm@tribat.vn" }
                    };
                    note = "<b>Anh/chị nhận được email này do nhân viên " + employee.FullName + " không có dữ liệu chấm công. Xin lỗi về bất tiện này và vui lòng kiểm tra lại.</b><br />";
                }

                var attachments = new List<string>
                {
                    excelViewModel.FileNameFullPath
                };

                var pathToFile = @"C:\Projects\App.Schedule\Templates\bangchamcong.html";
                var bodyBuilder = new BodyBuilder();
                using (StreamReader SourceReader = File.OpenText(pathToFile))
                {
                    bodyBuilder.HtmlBody = SourceReader.ReadToEnd();
                }
                string messageBody = string.Format(bodyBuilder.HtmlBody,
                    subject,
                    note,
                    " anh/chị " + to2,
                    thang + "-" + nam + owner,
                    "28/" + thang.ToString("00") + "/" + nam,
                    excelViewModel.NgayCongNT,
                    excelViewModel.NgayNghiP,
                    url + "/" + Constants.LinkTimeKeeper.Main + "/" + Constants.LinkTimeKeeper.Index,
                    url + "/" + Constants.LinkLeave.Main + "/" + Constants.LinkLeave.Index,
                    url);

                var emailMessage = new EmailMessage()
                {
                    ToAddresses = tos,
                    Subject = subject,
                    BodyContent = messageBody,
                    Type = "bang-cham-cong",
                    EmployeeId = employee.Id,
                    Attachments = attachments
                };

                ScheduleMail(connection, database, emailMessage);
                #endregion
            }
            #endregion

            //#region Step 2: Employee miss email: Have manager
            //var listEmptyEmail = results.Where(m => string.IsNullOrEmpty(m.Email) && !string.IsNullOrEmpty(m.ManageId)).ToList();
            //var groupManager = (from s in listEmptyEmail
            //                    group s by new
            //                    {
            //                        s.ManageId
            //                    }
            //                                        into l
            //                    select new
            //                    {
            //                        l.Key.ManageId,
            //                        list = l.ToList(),
            //                    }).ToList();
            //foreach (var manager in groupManager)
            //{
            //    var listControl = manager.list;
            //    string sFileName = @"bang-cham-cong";
            //    sFileName += "-" + thang + "-" + nam;
            //    var managerE = dbContext.Employees.Find(m => m.Id.Equals(manager.ManageId)).FirstOrDefault();
            //    if (managerE != null && !string.IsNullOrEmpty(managerE.Email))
            //    {
            //        sFileName += "-nhan-vien-cua-" + managerE.AliasFullName + ".xlsx";

            //        var excelViewModel = RenderExcel(Tu, Den, ngaychot, sFileName, 2, listControl);

            //        #region SEND MAIL
            //        Console.WriteLine("Send email to:" + managerE.Email);
            //        subject = "CHẤM CÔNG THÁNG " + thang + "-" + nam + " CỦA NHÂN VIÊN ĐANG QUẢN LÝ";
            //        note = "<b>Xin lỗi về bất tiện này. Anh/chị nhận được email này do đang quản lý danh sách nhân viên (chưa có thông tin email). Vui lòng xem công và liên hệ nhân viên liên quan.</b><br />";
            //        to2 = managerE.FullName;
            //        var tos = new List<EmailAddress>
            //        {
            //            new EmailAddress { Name = managerE.FullName, Address = managerE.Email }
            //        };

            //        var attachments = new List<string>
            //        {
            //            excelViewModel.FileNameFullPath
            //        };

            //        var pathToFile = @"C:\Projects\App.Schedule\Templates\bangchamcongnhom.html";
            //        var bodyBuilder = new BodyBuilder();
            //        using (StreamReader SourceReader = File.OpenText(pathToFile))
            //        {
            //            bodyBuilder.HtmlBody = SourceReader.ReadToEnd();
            //        }
            //        string messageBody = string.Format(bodyBuilder.HtmlBody,
            //            subject,
            //            note,
            //            " anh/chị " + to2,
            //            thang + "-" + nam,
            //            "28/" + thang.ToString("00") + "/" + nam,
            //            url + "/" + Constants.LinkTimeKeeper.Main + "/" + Constants.LinkTimeKeeper.Index,
            //            url + "/" + Constants.LinkLeave.Main + "/" + Constants.LinkLeave.Index,
            //            url);

            //        var emailMessage = new EmailMessage()
            //        {
            //            ToAddresses = tos,
            //            Subject = subject,
            //            BodyContent = messageBody,
            //            Type = "bang-cham-cong-nhom",
            //            EmployeeId = managerE.Id,
            //            Attachments = attachments
            //        };

            //        ScheduleMail(connection, database, emailMessage);
            //        #endregion
            //    }
            //    else
            //    {
            //        // Gui HR
            //        sFileName = @"bang-cham-cong";
            //        sFileName += "-" + thang + "-" + nam;
            //        subject = "CHẤM CÔNG THÁNG " + thang + "-" + nam;
            //        note = "<b>Xin lỗi về bất tiện này. Anh/chị nhận được email này do đang quản lý danh sách nhân viên (chưa có thông tin email và chưa có người quản lý trực tiếp). Vui lòng xem công và liên hệ nhân viên liên quan.</b><br />";
            //        var tos = new List<EmailAddress>();
            //        sFileName += "-nhan-vien-nha-may.xlsx";
            //        subject += " CỦA NHÂN VIÊN NHÀ MÁY";
            //        foreach (var hrEmployee in hrsNhaMay)
            //        {
            //            to2 += string.IsNullOrEmpty(to2) ? hrEmployee.FullName : ", " + hrEmployee.FullName;
            //            tos.Add(new EmailAddress { Name = hrEmployee.FullName, Address = hrEmployee.Email });
            //        }
            //        var excelViewModel = RenderExcel(Tu, Den, ngaychot, sFileName, 2, listControl);

            //        var attachments = new List<string>
            //        {
            //            excelViewModel.FileNameFullPath
            //        };

            //        var pathToFile = @"C:\Projects\App.Schedule\Templates\bangchamcongnhom.html";
            //        var bodyBuilder = new BodyBuilder();
            //        using (StreamReader SourceReader = File.OpenText(pathToFile))
            //        {
            //            bodyBuilder.HtmlBody = SourceReader.ReadToEnd();
            //        }
            //        string messageBody = string.Format(bodyBuilder.HtmlBody,
            //            subject,
            //            note,
            //            " anh/chị " + to2,
            //            thang + "-" + nam,
            //            "28/" + thang.ToString("00") + "/" + nam,
            //            url + "/" + Constants.LinkTimeKeeper.Main + "/" + Constants.LinkTimeKeeper.Index,
            //            url + "/" + Constants.LinkLeave.Main + "/" + Constants.LinkLeave.Index,
            //            url);

            //        var emailMessage = new EmailMessage()
            //        {
            //            ToAddresses = tos,
            //            Subject = subject,
            //            BodyContent = messageBody,
            //            Type = "bang-cham-cong-nhom",
            //            EmployeeId = string.Empty,
            //            Attachments = attachments
            //        };

            //        ScheduleMail(connection, database, emailMessage);
            //    }
            //}
            //#endregion

            //#region Step 3: Employee miss email, miss manager
            //var listEmptyEmailNoManager = results.Where(m => string.IsNullOrEmpty(m.Email) && string.IsNullOrEmpty(m.ManageId)).ToList();
            //var groupHrs = (from s in listEmptyEmailNoManager
            //                group s by new
            //                {
            //                    s.CongTyChiNhanh
            //                }
            //                                        into l
            //                select new
            //                {
            //                    l.Key.CongTyChiNhanh,
            //                    list = l.ToList(),
            //                }).ToList();
            //foreach (var grouphr in groupHrs)
            //{
            //    string sFileName = @"bang-cham-cong";
            //    sFileName += "-" + thang + "-" + nam;

            //    subject = "CHẤM CÔNG THÁNG " + thang + "-" + nam;
            //    note = "<b>Xin lỗi về bất tiện này. Anh/chị nhận được email này do đang quản lý danh sách nhân viên (chưa có thông tin email và chưa có người quản lý trực tiếp). Vui lòng xem công và liên hệ nhân viên liên quan.</b><br />";
            //    var tos = new List<EmailAddress>();
            //    if (grouphr.CongTyChiNhanh == congtychinhanhTruSo.Id)
            //    {
            //        sFileName += "-nhan-vien-khoi-van-phong.xlsx";
            //        subject += " CỦA NHÂN VIÊN KHỐI VĂN PHÒNG";

            //        foreach (var hrEmployee in hrsCongTy)
            //        {
            //            to2 += string.IsNullOrEmpty(to2) ? hrEmployee.FullName : ", " + hrEmployee.FullName;
            //            tos.Add(new EmailAddress { Name = hrEmployee.FullName, Address = hrEmployee.Email });
            //        }
            //    }
            //    else
            //    {
            //        sFileName += "-nhan-vien-nha-may.xlsx";
            //        subject += " CỦA NHÂN VIÊN NHÀ MÁY";
            //        foreach (var hrEmployee in hrsNhaMay)
            //        {
            //            to2 += string.IsNullOrEmpty(to2) ? hrEmployee.FullName : ", " + hrEmployee.FullName;
            //            tos.Add(new EmailAddress { Name = hrEmployee.FullName, Address = hrEmployee.Email });
            //        }
            //    }
            //    var listControl = grouphr.list;
            //    var excelViewModel = RenderExcel(Tu, Den, ngaychot, sFileName, 2, listControl);

            //    var attachments = new List<string>
            //        {
            //            excelViewModel.FileNameFullPath
            //        };

            //    var pathToFile = @"C:\Projects\App.Schedule\Templates\bangchamcongnhom.html";
            //    var bodyBuilder = new BodyBuilder();
            //    using (StreamReader SourceReader = File.OpenText(pathToFile))
            //    {
            //        bodyBuilder.HtmlBody = SourceReader.ReadToEnd();
            //    }
            //    string messageBody = string.Format(bodyBuilder.HtmlBody,
            //        subject,
            //        note,
            //        " anh/chị " + to2,
            //        thang + "-" + nam,
            //        "28/" + thang.ToString("00") + "/" + nam,
            //        url + "/" + Constants.LinkTimeKeeper.Main + "/" + Constants.LinkTimeKeeper.Index,
            //        url + "/" + Constants.LinkLeave.Main + "/" + Constants.LinkLeave.Index,
            //        url);

            //    var emailMessage = new EmailMessage()
            //    {
            //        ToAddresses = tos,
            //        Subject = subject,
            //        BodyContent = messageBody,
            //        Type = "bang-cham-cong-nhom",
            //        EmployeeId = string.Empty,
            //        Attachments = attachments
            //    };

            //    ScheduleMail(connection, database, emailMessage);
            //}
            //#endregion
        }

        static ExcelViewModel RenderExcel(DateTime Tu, DateTime Den, DateTime ngaychot, string sFileName, int mode, List<TimeKeeperDisplay> list)
        {
            #region Declare
            double ngayCongNT = 0;
            double ngayCongCT = 0;
            double gioCongNT = 0;
            double gioCongCT = 0;
            int vaoTreLan = 0;
            double vaoTrePhut = 0;
            int raSomLan = 0;
            double raSomPhut = 0;
            double TC1 = 0;
            double TC2 = 0;
            double TC3 = 0;
            double vangKP = 0;
            double ngayNghiP = 0;
            double ngayNghiOM = 0;
            double ngayNghiTS = 0;
            double ngayNghiR = 0;
            #endregion

            #region RENDER EXCEL FILE
            var root = @"C:\Projects\App.Schedule";
            string exportFolder = Path.Combine(root, "exports", "timers", ngaychot.ToString("yyyyMMdd"));
            FileInfo file = new FileInfo(Path.Combine(exportFolder, sFileName));
            file.Directory.Create(); // If the directory already exists, this method does nothing.
            using (var fs = new FileStream(Path.Combine(exportFolder, sFileName), FileMode.Create, FileAccess.Write))
            {
                IWorkbook workbook = new XSSFWorkbook();
                #region Styling
                var font = workbook.CreateFont();
                font.FontHeightInPoints = 8;
                font.FontName = "Arial";

                var fontSmall = workbook.CreateFont();
                fontSmall.FontHeightInPoints = 5;
                fontSmall.FontName = "Arial";

                var fontbold = workbook.CreateFont();
                fontbold.FontHeightInPoints = 8;
                fontbold.FontName = "Arial";
                fontbold.Boldweight = (short)FontBoldWeight.Bold;

                var fontbold8 = workbook.CreateFont();
                fontbold8.FontHeightInPoints = 8;
                fontbold8.FontName = "Arial";
                fontbold8.Boldweight = (short)FontBoldWeight.Bold;

                var fontbold10 = workbook.CreateFont();
                fontbold10.FontHeightInPoints = 10;
                fontbold10.FontName = "Arial";
                fontbold10.Boldweight = (short)FontBoldWeight.Bold;

                var fontbold12 = workbook.CreateFont();
                fontbold12.FontHeightInPoints = 12;
                fontbold12.FontName = "Arial";
                fontbold12.Boldweight = (short)FontBoldWeight.Bold;

                var styleBorder = workbook.CreateCellStyle();
                styleBorder.BorderBottom = BorderStyle.Thin;
                styleBorder.BorderLeft = BorderStyle.Thin;
                styleBorder.BorderRight = BorderStyle.Thin;
                styleBorder.BorderTop = BorderStyle.Thin;

                var styleBorderDot = workbook.CreateCellStyle();
                styleBorderDot.BorderBottom = BorderStyle.Dotted;
                styleBorderDot.BorderLeft = BorderStyle.Thin;
                styleBorderDot.BorderRight = BorderStyle.Thin;
                styleBorderDot.BorderTop = BorderStyle.Thin;

                var styleCenter = workbook.CreateCellStyle();
                styleCenter.Alignment = HorizontalAlignment.Center;
                styleCenter.VerticalAlignment = VerticalAlignment.Center;

                var styleCenterBorder = workbook.CreateCellStyle();
                styleCenterBorder.CloneStyleFrom(styleBorder);
                styleCenterBorder.Alignment = HorizontalAlignment.Center;
                styleCenterBorder.VerticalAlignment = VerticalAlignment.Center;

                var cellStyleBorderAndColorGreen = workbook.CreateCellStyle();
                cellStyleBorderAndColorGreen.CloneStyleFrom(styleBorder);
                cellStyleBorderAndColorGreen.CloneStyleFrom(styleCenter);
                cellStyleBorderAndColorGreen.FillPattern = FillPattern.SolidForeground;
                ((XSSFCellStyle)cellStyleBorderAndColorGreen).SetFillForegroundColor(new XSSFColor(new byte[] { 198, 239, 206 }));

                var cellStyleBorderAndColorYellow = workbook.CreateCellStyle();
                cellStyleBorderAndColorYellow.CloneStyleFrom(styleBorder);
                cellStyleBorderAndColorYellow.FillPattern = FillPattern.SolidForeground;
                ((XSSFCellStyle)cellStyleBorderAndColorYellow).SetFillForegroundColor(new XSSFColor(new byte[] { 255, 235, 156 }));

                var styleDedault = workbook.CreateCellStyle();
                styleDedault.CloneStyleFrom(styleBorder);
                styleDedault.SetFont(font);

                var styleDot = workbook.CreateCellStyle();
                styleDot.CloneStyleFrom(styleBorderDot);
                styleDot.SetFont(font);

                var styleTitle = workbook.CreateCellStyle();
                styleTitle.CloneStyleFrom(styleCenter);
                styleTitle.SetFont(fontbold12);

                var styleSubTitle = workbook.CreateCellStyle();
                styleSubTitle.CloneStyleFrom(styleCenter);
                styleSubTitle.SetFont(fontbold8);

                var styleHeader = workbook.CreateCellStyle();
                styleHeader.CloneStyleFrom(styleCenterBorder);
                styleHeader.SetFont(fontbold8);

                var styleDedaultMerge = workbook.CreateCellStyle();
                styleDedaultMerge.CloneStyleFrom(styleCenter);
                styleDedaultMerge.SetFont(font);

                var styleFullText = workbook.CreateCellStyle();
                styleDedaultMerge.SetFont(font);
                styleFullText.WrapText = true;

                var styleBold = workbook.CreateCellStyle();
                styleBold.SetFont(fontbold8);

                var styleSmall = workbook.CreateCellStyle();
                styleSmall.CloneStyleFrom(styleBorder);
                styleSmall.SetFont(fontSmall);
                #endregion

                ISheet sheet1 = workbook.CreateSheet("Cong");

                #region Introduce
                var rowIndex = 0;
                var columnIndex = 0;
                IRow row = sheet1.CreateRow(rowIndex);
                var cell = row.CreateCell(columnIndex, CellType.String);
                cell.SetCellValue("Công ty TNHH CNSH SÀI GÒN XANH");
                cell.CellStyle = styleBold;
                rowIndex++;

                row = sheet1.CreateRow(rowIndex);
                cell = row.CreateCell(columnIndex, CellType.String);
                cell.SetCellValue("Địa chỉ: 127 Nguyễn Trọng Tuyển - P.15 - Q.Phú Nhuận - Tp HCM");
                cell.CellStyle = styleBold;
                rowIndex++;

                row = sheet1.CreateRow(rowIndex);
                cell = row.CreateCell(columnIndex, CellType.String);
                cell.SetCellValue("Điện thoại: (08)-39971869 - 38442457 - Fax: 08-39971869");
                cell.CellStyle = styleBold;
                rowIndex++;

                row = sheet1.CreateRow(rowIndex);
                cell = row.CreateCell(columnIndex, CellType.String);
                cell.SetCellValue("MST: 0302519810");
                cell.CellStyle = styleBold;
                rowIndex++;
                #endregion

                row = sheet1.CreateRow(rowIndex);
                CellRangeAddress cellRangeAddress = new CellRangeAddress(rowIndex, rowIndex, columnIndex, columnIndex + 9);
                sheet1.AddMergedRegion(cellRangeAddress);
                cell = row.CreateCell(columnIndex, CellType.String);
                cell.SetCellValue("BẢNG THỐNG KÊ CHẤM CÔNG");
                cell.CellStyle = styleTitle;
                rowIndex++;

                #region Header
                row = sheet1.CreateRow(rowIndex);
                cellRangeAddress = new CellRangeAddress(rowIndex, rowIndex, columnIndex, columnIndex + 9);
                sheet1.AddMergedRegion(cellRangeAddress);
                cell = row.CreateCell(columnIndex, CellType.String);
                cell.SetCellValue("Từ ngày " + Tu.ToString("dd/MM/yyyy") + " đến ngày " + Den.ToString("dd/MM/yyyy"));
                cell.CellStyle = styleSubTitle;
                rowIndex++;
                rowIndex++;

                row = sheet1.CreateRow(rowIndex);
                cell = row.CreateCell(columnIndex, CellType.String);
                cell.SetCellValue("#");
                cell.CellStyle = styleHeader;
                columnIndex++;

                cell = row.CreateCell(columnIndex, CellType.String);
                cell.SetCellValue("Mã NV");
                cell.CellStyle = styleHeader;
                columnIndex++;

                cell = row.CreateCell(columnIndex, CellType.String);
                cell.SetCellValue("Họ tên");
                cell.CellStyle = styleHeader;
                columnIndex++;

                cell = row.CreateCell(columnIndex, CellType.String);
                cell.SetCellValue("Chức vụ");
                cell.CellStyle = styleHeader;
                columnIndex++;

                cell = row.CreateCell(columnIndex, CellType.String);
                cell.SetCellValue("Mã chấm công");
                cell.CellStyle = styleHeader;
                columnIndex++;

                cell = row.CreateCell(columnIndex, CellType.String);
                cell.SetCellValue(string.Empty);
                cell.CellStyle = styleHeader;
                columnIndex++;

                for (DateTime date = Tu; date <= Den; date = date.AddDays(1))
                {
                    cell = row.CreateCell(columnIndex);
                    cell.SetCellValue(date.Day);
                    cell.CellStyle = styleHeader;
                    columnIndex++;
                }

                cellRangeAddress = new CellRangeAddress(rowIndex, rowIndex, columnIndex, columnIndex + 1);
                sheet1.AddMergedRegion(cellRangeAddress);
                cell = row.CreateCell(columnIndex, CellType.String);
                cell.SetCellValue("Ngày công");
                cell.CellStyle = styleHeader;
                RegionUtil.SetBorderTop((int)BorderStyle.Thin, cellRangeAddress, sheet1, workbook);
                RegionUtil.SetBorderLeft((int)BorderStyle.Thin, cellRangeAddress, sheet1, workbook);
                RegionUtil.SetBorderRight((int)BorderStyle.Thin, cellRangeAddress, sheet1, workbook);
                RegionUtil.SetBorderBottom((int)BorderStyle.Thin, cellRangeAddress, sheet1, workbook);
                columnIndex = columnIndex + 1;
                columnIndex++;

                cellRangeAddress = new CellRangeAddress(rowIndex, rowIndex, columnIndex, columnIndex + 1);
                sheet1.AddMergedRegion(cellRangeAddress);
                cell = row.CreateCell(columnIndex, CellType.String);
                cell.SetCellValue("Vào trễ");
                cell.CellStyle = styleHeader;
                RegionUtil.SetBorderTop((int)BorderStyle.Thin, cellRangeAddress, sheet1, workbook);
                RegionUtil.SetBorderLeft((int)BorderStyle.Thin, cellRangeAddress, sheet1, workbook);
                RegionUtil.SetBorderRight((int)BorderStyle.Thin, cellRangeAddress, sheet1, workbook);
                RegionUtil.SetBorderBottom((int)BorderStyle.Thin, cellRangeAddress, sheet1, workbook);
                columnIndex = columnIndex + 1;
                columnIndex++;

                cellRangeAddress = new CellRangeAddress(rowIndex, rowIndex, columnIndex, columnIndex + 1);
                sheet1.AddMergedRegion(cellRangeAddress);
                cell = row.CreateCell(columnIndex, CellType.String);
                cell.SetCellValue("Ra sớm");
                cell.CellStyle = styleHeader;
                RegionUtil.SetBorderTop((int)BorderStyle.Thin, cellRangeAddress, sheet1, workbook);
                RegionUtil.SetBorderLeft((int)BorderStyle.Thin, cellRangeAddress, sheet1, workbook);
                RegionUtil.SetBorderRight((int)BorderStyle.Thin, cellRangeAddress, sheet1, workbook);
                RegionUtil.SetBorderBottom((int)BorderStyle.Thin, cellRangeAddress, sheet1, workbook);
                columnIndex = columnIndex + 1;
                columnIndex++;

                cellRangeAddress = new CellRangeAddress(rowIndex, rowIndex, columnIndex, columnIndex + 2);
                sheet1.AddMergedRegion(cellRangeAddress);
                cell = row.CreateCell(columnIndex, CellType.String);
                cell.SetCellValue("Tăng ca");
                cell.CellStyle = styleHeader;
                RegionUtil.SetBorderTop((int)BorderStyle.Thin, cellRangeAddress, sheet1, workbook);
                RegionUtil.SetBorderLeft((int)BorderStyle.Thin, cellRangeAddress, sheet1, workbook);
                RegionUtil.SetBorderRight((int)BorderStyle.Thin, cellRangeAddress, sheet1, workbook);
                RegionUtil.SetBorderBottom((int)BorderStyle.Thin, cellRangeAddress, sheet1, workbook);
                columnIndex = columnIndex + 2;
                columnIndex++;

                cellRangeAddress = new CellRangeAddress(rowIndex, rowIndex, columnIndex, columnIndex + 1);
                sheet1.AddMergedRegion(cellRangeAddress);
                cell = row.CreateCell(columnIndex, CellType.String);
                cell.SetCellValue("Ngày nghỉ");
                cell.CellStyle = styleHeader;
                RegionUtil.SetBorderTop((int)BorderStyle.Thin, cellRangeAddress, sheet1, workbook);
                RegionUtil.SetBorderLeft((int)BorderStyle.Thin, cellRangeAddress, sheet1, workbook);
                RegionUtil.SetBorderRight((int)BorderStyle.Thin, cellRangeAddress, sheet1, workbook);
                RegionUtil.SetBorderBottom((int)BorderStyle.Thin, cellRangeAddress, sheet1, workbook);

                rowIndex++;

                row = sheet1.CreateRow(rowIndex);
                columnIndex = 6;
                for (DateTime date = Tu; date <= Den; date = date.AddDays(1.0))
                {
                    cell = row.CreateCell(columnIndex); // cell B1
                    cell.SetCellValue(Constants.DayOfWeekT2(date));
                    cell.CellStyle = styleHeader;
                    columnIndex++;
                }

                cell = row.CreateCell(columnIndex);
                cell.SetCellValue("NT");
                cell.CellStyle = styleHeader;
                columnIndex++;
                cell = row.CreateCell(columnIndex);
                cell.SetCellValue("CT");
                cell.CellStyle = styleHeader;
                columnIndex++;

                cell = row.CreateCell(columnIndex);
                cell.SetCellValue("Lần");
                cell.CellStyle = styleHeader;
                columnIndex++;
                cell = row.CreateCell(columnIndex);
                cell.SetCellValue("Phút");
                cell.CellStyle = styleHeader;
                columnIndex++;
                cell = row.CreateCell(columnIndex);
                cell.SetCellValue("Lần");
                cell.CellStyle = styleHeader;
                columnIndex++;
                cell = row.CreateCell(columnIndex);
                cell.SetCellValue("Phút");
                cell.CellStyle = styleHeader;
                columnIndex++;
                cell = row.CreateCell(columnIndex);
                cell.SetCellValue("TC1");
                cell.CellStyle = styleHeader;
                columnIndex++;
                cell = row.CreateCell(columnIndex);
                cell.SetCellValue("TC2");
                cell.CellStyle = styleHeader;
                columnIndex++;

                cell = row.CreateCell(columnIndex);
                cell.SetCellValue("TC3");
                cell.CellStyle = styleHeader;
                columnIndex++;

                cell = row.CreateCell(columnIndex);
                cell.SetCellValue("KP");
                cell.CellStyle = styleHeader;
                columnIndex++;

                cell = row.CreateCell(columnIndex);
                cell.SetCellValue("P");
                cell.CellStyle = styleHeader;
                columnIndex++;

                rowIndex++;
                #endregion

                var order = 1;
                foreach (var employee in list)
                {
                    var timers = employee.EmployeeWorkTimeLogs;
                    var timesSort = timers.OrderBy(m => m.Date).ToList();

                    ngayCongNT = 0;
                    ngayCongCT = 0;
                    gioCongNT = 0;
                    gioCongCT = 0;
                    vaoTreLan = 0;
                    vaoTrePhut = 0;
                    raSomLan = 0;
                    raSomPhut = 0;
                    TC1 = 0;
                    TC2 = 0;
                    TC3 = 0;
                    vangKP = 0;
                    ngayNghiP = 0;
                    ngayNghiOM = 0;
                    ngayNghiTS = 0;
                    ngayNghiR = 0;

                    var rowEF = rowIndex;
                    var rowET = rowIndex + 4;

                    row = sheet1.CreateRow(rowIndex);

                    columnIndex = 0;
                    cellRangeAddress = new CellRangeAddress(rowIndex, rowIndex + 4, columnIndex, columnIndex);
                    sheet1.AddMergedRegion(cellRangeAddress);
                    cell = row.CreateCell(columnIndex, CellType.String);
                    cell.SetCellValue(order);
                    cell.CellStyle = styleDedaultMerge;
                    columnIndex++;

                    cellRangeAddress = new CellRangeAddress(rowIndex, rowIndex + 4, columnIndex, columnIndex);
                    sheet1.AddMergedRegion(cellRangeAddress);
                    cell = row.CreateCell(columnIndex, CellType.String);
                    cell.SetCellValue(employee.Code);
                    cell.CellStyle = styleFullText;
                    columnIndex++;

                    cellRangeAddress = new CellRangeAddress(rowIndex, rowIndex + 4, columnIndex, columnIndex);
                    sheet1.AddMergedRegion(cellRangeAddress);
                    cell = row.CreateCell(columnIndex, CellType.String);
                    cell.SetCellValue(employee.FullName);
                    cell.CellStyle = styleFullText;
                    columnIndex++;

                    cellRangeAddress = new CellRangeAddress(rowIndex, rowIndex + 4, columnIndex, columnIndex);
                    sheet1.AddMergedRegion(cellRangeAddress);
                    cell = row.CreateCell(columnIndex, CellType.String);
                    cell.SetCellValue(employee.ChucVu);
                    cell.CellStyle = styleFullText;
                    columnIndex++;

                    cellRangeAddress = new CellRangeAddress(rowIndex, rowIndex + 4, columnIndex, columnIndex);
                    sheet1.AddMergedRegion(cellRangeAddress);
                    cell = row.CreateCell(columnIndex, CellType.Numeric);
                    cell.SetCellValue(Convert.ToInt32(employee.EnrollNumber));
                    cell.CellStyle = styleFullText;
                    columnIndex++;

                    cell = row.CreateCell(columnIndex, CellType.String);
                    cell.SetCellValue("Vào 1");
                    cell.CellStyle = styleDedault;

                    var rowout1 = sheet1.CreateRow(rowIndex + 1);
                    var rowin2 = sheet1.CreateRow(rowIndex + 2);
                    var rowout2 = sheet1.CreateRow(rowIndex + 3);
                    var rowreason = sheet1.CreateRow(rowIndex + 4);

                    cell = rowout1.CreateCell(columnIndex, CellType.String);
                    cell.SetCellValue("Ra 1");
                    cell.CellStyle = styleDedault;

                    cell = rowin2.CreateCell(columnIndex, CellType.String);
                    cell.SetCellValue("Vào 2");
                    cell.CellStyle = styleDedault;

                    cell = rowout2.CreateCell(columnIndex, CellType.String);
                    cell.SetCellValue("Ra 2");
                    cell.CellStyle = styleDedault;

                    cell = rowreason.CreateCell(columnIndex, CellType.String);
                    cell.SetCellValue("Xác nhận-Lý do");
                    cell.CellStyle = styleDedault;
                    columnIndex++;

                    for (DateTime date = Tu; date <= Den; date = date.AddDays(1.0))
                    {
                        var item = timesSort.Where(m => m.Date.Equals(date)).FirstOrDefault();
                        if (item != null)
                        {
                            var modeMiss = false;
                            if (item.Mode == (int)ETimeWork.Normal)
                            {
                                switch (item.Status)
                                {
                                    case (int)EStatusWork.XacNhanCong:
                                        {
                                            modeMiss = true;
                                            break;
                                        }
                                    case (int)EStatusWork.DaGuiXacNhan:
                                        {
                                            modeMiss = true;
                                            break;
                                        }
                                    case (int)EStatusWork.DongY:
                                        {
                                            ngayCongNT++;
                                            break;
                                        }
                                    case (int)EStatusWork.TuChoi:
                                        {
                                            modeMiss = true;
                                            break;
                                        }
                                    default:
                                        {
                                            ngayCongNT++;
                                            break;
                                        }
                                }
                            }

                            if (modeMiss)
                            {
                                if (item.Late.TotalMinutes > 1)
                                {
                                    vaoTreLan++;
                                    vaoTrePhut += item.Late.TotalMinutes;
                                }
                                if (item.Early.TotalMinutes > 1)
                                {
                                    raSomLan++;
                                    raSomPhut += item.Early.TotalMinutes;
                                }
                                // First, không tính 15p
                                var timeoutin = item.Out - item.In;
                                if (timeoutin.HasValue && timeoutin.Value.TotalHours > 6)
                                {
                                    ngayCongNT++;
                                }
                                else
                                {
                                    ngayCongNT += item.WorkDay;
                                }
                            }

                            if (item.Mode == (int)ETimeWork.LeavePhep)
                            {
                                ngayNghiP += item.SoNgayNghi;
                            }

                            if (item.Mode > (int)ETimeWork.Normal && item.Logs == null)
                            {
                                cellRangeAddress = new CellRangeAddress(rowIndex, rowIndex + 4, columnIndex, columnIndex);
                                sheet1.AddMergedRegion(cellRangeAddress);
                                cell = row.CreateCell(columnIndex, CellType.String);
                                cell.SetCellValue(item.Reason);
                                cell.CellStyle = styleDedaultMerge;
                                var rowCellRangeAddress = new CellRangeAddress(rowEF, rowET, columnIndex, columnIndex);
                                sheet1.AddMergedRegion(rowCellRangeAddress);
                                RegionUtil.SetBorderTop((int)BorderStyle.Thin, rowCellRangeAddress, sheet1, workbook);
                                RegionUtil.SetBorderLeft((int)BorderStyle.Thin, rowCellRangeAddress, sheet1, workbook);
                                RegionUtil.SetBorderRight((int)BorderStyle.Thin, rowCellRangeAddress, sheet1, workbook);
                                RegionUtil.SetBorderBottom((int)BorderStyle.Thin, rowCellRangeAddress, sheet1, workbook);

                            }
                            else
                            {
                                var displayIn1 = string.Empty;
                                var displayIn2 = string.Empty;
                                var displayOut1 = string.Empty;
                                var displayOut2 = string.Empty;
                                if (item.In.HasValue)
                                {
                                    displayIn1 = item.In.ToString();
                                }
                                if (item.Out.HasValue)
                                {
                                    displayOut1 = item.Out.ToString();
                                }

                                cell = row.CreateCell(columnIndex, CellType.String);
                                cell.SetCellValue(displayIn1);
                                cell.CellStyle = styleDot;

                                cell = rowout1.CreateCell(columnIndex, CellType.String);
                                cell.SetCellValue(displayOut1);
                                cell.CellStyle = styleDedault;

                                cell = rowin2.CreateCell(columnIndex, CellType.String);
                                cell.SetCellValue(displayIn2);
                                if (!string.IsNullOrEmpty(displayIn2))
                                {
                                    cell.CellStyle = styleDot;
                                }
                                else
                                {
                                    cell.CellStyle = styleDedault;
                                }

                                cell = rowout2.CreateCell(columnIndex, CellType.String);
                                cell.SetCellValue(displayOut2);
                                cell.CellStyle = styleDedault;

                                cell = rowreason.CreateCell(columnIndex, CellType.String);
                                cell.SetCellValue(item.Reason + ": " + Constants.Truncate(item.ReasonDetail, 50));
                                cell.CellStyle = styleSmall;
                            }

                            columnIndex++;
                        }
                        else
                        {
                            cellRangeAddress = new CellRangeAddress(rowIndex, rowIndex + 4, columnIndex, columnIndex);
                            sheet1.AddMergedRegion(cellRangeAddress);
                            cell = row.CreateCell(columnIndex, CellType.String);
                            cell.SetCellValue(Constants.NA);
                            cell.CellStyle = styleDedaultMerge;
                            var rowCellRangeAddress = new CellRangeAddress(rowEF, rowET, columnIndex, columnIndex);
                            sheet1.AddMergedRegion(rowCellRangeAddress);
                            RegionUtil.SetBorderTop((int)BorderStyle.Thin, rowCellRangeAddress, sheet1, workbook);
                            RegionUtil.SetBorderLeft((int)BorderStyle.Thin, rowCellRangeAddress, sheet1, workbook);
                            RegionUtil.SetBorderRight((int)BorderStyle.Thin, rowCellRangeAddress, sheet1, workbook);
                            RegionUtil.SetBorderBottom((int)BorderStyle.Thin, rowCellRangeAddress, sheet1, workbook);
                            columnIndex++;
                        }
                    }

                    var columnIndexF = columnIndex;
                    cellRangeAddress = new CellRangeAddress(rowIndex, rowIndex + 4, columnIndex, columnIndex);
                    sheet1.AddMergedRegion(cellRangeAddress);
                    cell = row.CreateCell(columnIndex, CellType.Numeric);
                    cell.SetCellValue(Math.Round(ngayCongNT, 2));
                    cell.CellStyle = styleDedaultMerge;
                    columnIndex++;

                    cellRangeAddress = new CellRangeAddress(rowIndex, rowIndex + 4, columnIndex, columnIndex);
                    sheet1.AddMergedRegion(cellRangeAddress);
                    cell = row.CreateCell(columnIndex, CellType.Numeric);
                    cell.SetCellValue(Math.Round(ngayCongCT, 2));
                    cell.CellStyle = styleDedaultMerge;
                    columnIndex++;

                    cellRangeAddress = new CellRangeAddress(rowIndex, rowIndex + 4, columnIndex, columnIndex);
                    sheet1.AddMergedRegion(cellRangeAddress);
                    cell = row.CreateCell(columnIndex, CellType.Numeric);
                    cell.SetCellValue(vaoTreLan);
                    cell.CellStyle = styleDedaultMerge;
                    columnIndex++;

                    cellRangeAddress = new CellRangeAddress(rowIndex, rowIndex + 4, columnIndex, columnIndex);
                    sheet1.AddMergedRegion(cellRangeAddress);
                    cell = row.CreateCell(columnIndex, CellType.Numeric);
                    cell.SetCellValue(Math.Round(vaoTrePhut, 2));
                    cell.CellStyle = styleDedaultMerge;
                    columnIndex++;

                    cellRangeAddress = new CellRangeAddress(rowIndex, rowIndex + 4, columnIndex, columnIndex);
                    sheet1.AddMergedRegion(cellRangeAddress);
                    cell = row.CreateCell(columnIndex, CellType.Numeric);
                    cell.SetCellValue(raSomLan);
                    cell.CellStyle = styleDedaultMerge;
                    columnIndex++;

                    cellRangeAddress = new CellRangeAddress(rowIndex, rowIndex + 4, columnIndex, columnIndex);
                    sheet1.AddMergedRegion(cellRangeAddress);
                    cell = row.CreateCell(columnIndex, CellType.Numeric);
                    cell.SetCellValue(Math.Round(raSomPhut, 2));
                    cell.CellStyle = styleDedaultMerge;
                    columnIndex++;

                    cellRangeAddress = new CellRangeAddress(rowIndex, rowIndex + 4, columnIndex, columnIndex);
                    sheet1.AddMergedRegion(cellRangeAddress);
                    cell = row.CreateCell(columnIndex, CellType.Numeric);
                    cell.SetCellValue(TC1);
                    cell.CellStyle = styleDedaultMerge;
                    columnIndex++;

                    cellRangeAddress = new CellRangeAddress(rowIndex, rowIndex + 4, columnIndex, columnIndex);
                    sheet1.AddMergedRegion(cellRangeAddress);
                    cell = row.CreateCell(columnIndex, CellType.Numeric);
                    cell.SetCellValue(TC2);
                    cell.CellStyle = styleDedaultMerge;
                    columnIndex++;

                    cellRangeAddress = new CellRangeAddress(rowIndex, rowIndex + 4, columnIndex, columnIndex);
                    sheet1.AddMergedRegion(cellRangeAddress);
                    cell = row.CreateCell(columnIndex, CellType.Numeric);
                    cell.SetCellValue(TC3);
                    cell.CellStyle = styleDedaultMerge;
                    columnIndex++;

                    cellRangeAddress = new CellRangeAddress(rowIndex, rowIndex + 4, columnIndex, columnIndex);
                    sheet1.AddMergedRegion(cellRangeAddress);
                    cell = row.CreateCell(columnIndex, CellType.Numeric);
                    cell.SetCellValue(vangKP);
                    cell.CellStyle = styleDedaultMerge;
                    columnIndex++;

                    cellRangeAddress = new CellRangeAddress(rowIndex, rowIndex + 4, columnIndex, columnIndex);
                    sheet1.AddMergedRegion(cellRangeAddress);
                    cell = row.CreateCell(columnIndex, CellType.Numeric);
                    cell.SetCellValue(ngayNghiP);
                    cell.CellStyle = styleDedaultMerge;

                    var columnIndexT = columnIndex;
                    columnIndex++;

                    rowIndex = rowIndex + 4;
                    rowIndex++;
                    order++;
                    #region fix border
                    for (var i = 0; i < 5; i++)
                    {
                        var rowCellRangeAddress = new CellRangeAddress(rowEF, rowET, i, i);
                        sheet1.AddMergedRegion(rowCellRangeAddress);
                        RegionUtil.SetBorderTop((int)BorderStyle.Thin, rowCellRangeAddress, sheet1, workbook);
                        RegionUtil.SetBorderLeft((int)BorderStyle.Thin, rowCellRangeAddress, sheet1, workbook);
                        RegionUtil.SetBorderRight((int)BorderStyle.Thin, rowCellRangeAddress, sheet1, workbook);
                        RegionUtil.SetBorderBottom((int)BorderStyle.Thin, rowCellRangeAddress, sheet1, workbook);
                    }
                    for (var y = columnIndexF; y <= columnIndexT; y++)
                    {
                        var rowCellRangeAddress = new CellRangeAddress(rowEF, rowET, y, y);
                        sheet1.AddMergedRegion(rowCellRangeAddress);
                        RegionUtil.SetBorderTop((int)BorderStyle.Thin, rowCellRangeAddress, sheet1, workbook);
                        RegionUtil.SetBorderLeft((int)BorderStyle.Thin, rowCellRangeAddress, sheet1, workbook);
                        RegionUtil.SetBorderRight((int)BorderStyle.Thin, rowCellRangeAddress, sheet1, workbook);
                        RegionUtil.SetBorderBottom((int)BorderStyle.Thin, rowCellRangeAddress, sheet1, workbook);
                    }
                    #endregion
                }

                #region fix border
                var rowF = 7;
                var rowT = 8;
                for (var i = 0; i < 6; i++)
                {
                    var rowCellRangeAddress = new CellRangeAddress(rowF, rowT, i, i);
                    sheet1.AddMergedRegion(rowCellRangeAddress);
                    RegionUtil.SetBorderTop((int)BorderStyle.Thin, rowCellRangeAddress, sheet1, workbook);
                    RegionUtil.SetBorderLeft((int)BorderStyle.Thin, rowCellRangeAddress, sheet1, workbook);
                    RegionUtil.SetBorderRight((int)BorderStyle.Thin, rowCellRangeAddress, sheet1, workbook);
                    RegionUtil.SetBorderBottom((int)BorderStyle.Thin, rowCellRangeAddress, sheet1, workbook);
                }
                #endregion

                workbook.Write(fs);
            }
            #endregion

            return new ExcelViewModel()
            {
                FileNameFullPath = Path.Combine(exportFolder, sFileName),
                NgayCongNT = ngayCongNT,
                NgayNghiP = ngayNghiP
            };
        }

        static void ScheduleMail(string connection, string database, EmailMessage emailMessage)
        {
            #region Connection, Setting & Filter
            MongoDBContext.ConnectionString = connection;
            MongoDBContext.DatabaseName = database;
            MongoDBContext.IsSSL = true;
            MongoDBContext dbContext = new MongoDBContext();
            #endregion

            var scheduleEmail = new ScheduleEmail
            {
                Status = (int)EEmailStatus.TimerMonth,
                To = emailMessage.ToAddresses,
                CC = emailMessage.CCAddresses,
                BCC = emailMessage.BCCAddresses,
                Type = emailMessage.Type,
                Title = emailMessage.Subject,
                Content = emailMessage.BodyContent,
                Attachments = emailMessage.Attachments,
                EmployeeId = emailMessage.EmployeeId
            };

            dbContext.ScheduleEmails.InsertOne(scheduleEmail);
        }
    }
}