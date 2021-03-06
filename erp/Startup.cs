﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using erp.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Data;
using Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Models;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace erp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // https://edi.wang/post/2017/10/16/get-client-ip-aspnet-20
            services.AddHttpContextAccessor();
            services.TryAddSingleton<IActionContextAccessor, ActionContextAccessor>();

            services.Configure<FormOptions>(options =>
            {
                options.ValueCountLimit = int.MaxValue;
            });

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseSqlServer(
            //        Configuration.GetConnectionString("DefaultConnection")));

            //services.AddDefaultIdentity<IdentityUser>()
            //    .AddEntityFrameworkStores<ApplicationDbContext>();

            // My config
            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                // Cookie settings
                //options.Cookie.HttpOnly = true;
                //options.Cookie.Expiration = TimeSpan.FromDays(150);
                // If the LoginPath isn't set, ASP.NET Core defaults 
                // the path to /Account/Login.
                options.LoginPath = "/tk/dang-nhap/";
                // If the AccessDeniedPath isn't set, ASP.NET Core defaults 
                // the path to /Account/AccessDenied.
                //options.AccessDeniedPath = "/Account/AccessDenied";
                //options.SlidingExpiration = true;
            });

            #region MongoDB
            MongoDBContext.ConnectionString = Configuration.GetSection("MongoConnection:ConnectionString").Value;
            MongoDBContext.DatabaseName = Configuration.GetSection("MongoConnection:DatabaseName").Value;
            MongoDBContext.IsSSL = Convert.ToBoolean(Configuration.GetSection("MongoConnection:IsSSL").Value);
            #endregion

            // Add application services.
            //services.AddTransient<IEmailSender, EmailSender>();
            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();

            services.AddSession(options =>
            {
                //// Set a short timeout for easy testing.
                //options.IdleTimeout = TimeSpan.FromSeconds(10);
                //options.Cookie.HttpOnly = true;
                // Make the session cookie essential
                options.Cookie.IsEssential = true;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            //services.AddAntiforgery(o => o.HeaderName = "XSRF-TOKEN");


            //--< set uploadsize large files >----
            services.Configure<FormOptions>(options =>
            {
                options.ValueLengthLimit = int.MaxValue;
                options.MultipartBodyLengthLimit = int.MaxValue;
                options.MultipartHeadersLengthLimit = int.MaxValue;
            });
            //--</ set uploadsize large files >----
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
