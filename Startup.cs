using Blazored.Toast;
using BlazorStrap;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Sales.Areas.Identity;
using Sales.Data;
using Sales.Models;
using Syncfusion.Blazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Sales.Pages.Purchases;
using static Sales.Pages.SellItems;
using static Sales.Pages.Utilities.Utilities;
using Blazored.Toast.Services;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Sales
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"), sqloptions => sqloptions.CommandTimeout(3000)).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
            services.AddDbContext<SalesPurchasesContext>(options =>
               options.UseSqlServer(
                   Configuration.GetConnectionString("DefaultConnection"), sqloptions => sqloptions.CommandTimeout(3000)).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();           
            services.Configure<IdentityOptions>(options =>
            {
                // Default Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(60);
                options.Lockout.MaxFailedAccessAttempts = 4;
                options.Lockout.AllowedForNewUsers = false;
            });
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<UserManagement>();
            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddSingleton<WeatherForecastService>();
            services.AddSyncfusionBlazor();
            services.AddBootstrapCss();
            services.AddBlazoredToast();
            services.AddMvc(options => options.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddScoped<StaffRoutineAdapter>();
            services.AddScoped<StockRoutineAdapter>();
            services.AddScoped<SalesRoutineAdapter>();
            services.AddScoped<PurchasesRoutineAdapter>();
            services.AddScoped<UnitRoutineAdapter>();
            services.AddScoped<ToastService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDA3NDU2QDMxMzgyZTM0MmUzMEFsTFNtZkhHOHcyT21XdUxzSGNJbXA0alZnK2JoenBHRVJLUHVCT2NmZXc9");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}


//Scaffold-DbContext "Server=ttemakasse;Database=SalesPurchases;User Id=sa;password=8686;Trusted_Connection=False;MultipleActiveResultSets=true;" Microsoft.EntityFrameworkCore.SqlServer -o Models -f -context "SalesPurchasesContext"

//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//{
//    if (!optionsBuilder.IsConfigured)
//    {
//        IConfigurationRoot configuration = new ConfigurationBuilder()
//                                      .SetBasePath(Directory.GetCurrentDirectory())
//                                      .AddJsonFile("appsettings.json")
//                                      .Build();
//        var connectionString = configuration.GetConnectionString("DefaultConnection");
//        optionsBuilder.UseSqlServer(connectionString);
//    }
//}

//using Microsoft.Extensions.Configuration;
//using System.IO;