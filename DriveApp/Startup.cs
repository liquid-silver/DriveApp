using DriveApp.Data;
using DriveApp.Data.Repository;
using DriveApp.Data.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;

namespace DriveApp
{
    public class Startup
    {
        private IConfigurationRoot confString;
        public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment)
        {
            confString = new ConfigurationBuilder().SetBasePath(hostingEnvironment.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // services for Identity
            //services.AddDbContextPool<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            //включаем Identity
            //services.AddIdentityCore<IdentityUser>();

            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(confString.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAdvertisements, AdvertisementsRepository>();
            services.AddTransient<ICategories, CategoriesRepository>();
            services.AddTransient<IDrivers, DriversRepository>();
            services.AddTransient<IEmployment, EmploymentRepository>();
            services.AddTransient<IImages, ImagesRepository>();
            services.AddTransient<IRoles, RolesRepository>();
            services.AddTransient<ITimetable, TimetableRepository>();
            services.AddTransient<ITrucks, TrucksRepository>();
            //services.AddTransient<IUserStore<IdentityUser>, FakeUserStore>();
            services.AddTransient<IUsers, UsersRepository>();
            services.AddTransient<IVehicles, VehiclesRepository>();

            // Identity for app
            //services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<AppDBContent>();

            // установка конфигурации подключения
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options => //CookieAuthenticationOptions
                {
                    options.LoginPath = new PathString("/Account/Login");
                });

            services.AddControllersWithViews();
            //services.AddRazorPages();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            app.UseStatusCodePages();
            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();

            //using (var scope = app.ApplicationServices.CreateScope())
            //{
            //    AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
            //    DBObjects.Initial(content);
            //}


            //app.UseHttpsRedirection();
            //app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();    // аутентификация
            app.UseAuthorization();     // авторизация

            //app.UseCookieAuthentication(new CookieAuthenticationOptions()
            //{
            //    AuthenticationScheme = "MyCookieMiddlewareInstance",
            //    CookieName = "MyCookieMiddlewareInstance",
            //    LoginPath = new PathString("/Home/Login/"),
            //    AccessDeniedPath = new PathString("/Home/AccessDenied/"),
            //    AutomaticAuthenticate = true,
            //    AutomaticChallenge = true
            //});



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "driver",
                            pattern: "{controller=MyPage}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(name: "default",
                            pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
