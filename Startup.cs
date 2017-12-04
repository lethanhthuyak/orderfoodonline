using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OrderFoodOnline.Data;
using OrderFoodOnline.Models;
using OrderFoodOnline.Services;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using OrderFoodOnline.Repository;
using Firebase.Database;
using OrderFoodOnline.Context;
using System.Reflection;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using System.Web.Http;
using Autofac.Integration.WebApi;
using Microsoft.Extensions.FileProviders;
using System.IO;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Http;
using OrderFoodOnline.Controllers.api;

namespace OrderFoodOnline
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();


            services.AddSingleton<IFileProvider>(
            new PhysicalFileProvider(
                Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")));

            services.AddMvc()
                    .AddSessionStateTempDataProvider();

            //services.AddMvc(options => {
            //    options.SslPort = 44300;
            //    options.Filters.Add(new RequireHttpsAttribute());
            //});


            services.AddSession();
            //services.AddIdentity<ApplicationUser, IdentityRole>()
            //        .AddEntityFrameworkStores<ApplicationDbContext>()
            //        .AddDefaultTokenProviders();

            //services.AddAuthentication().AddFacebook(facebookOptions =>
            //{
            //    facebookOptions.AppId = Configuration["Authentication:Facebook:2071355189764284"];
            //    facebookOptions.AppSecret = Configuration["Authentication:Facebook:b0be32c0f33ead6a6364f0245b40bb83"];
            //});

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddMemoryCache();
            services.AddHttpContextAccessor();
            return ConfigureAutofac(services);

        }

        public IServiceProvider ConfigureAutofac(IServiceCollection services)
        {


            // Add application services.

            var builder = new ContainerBuilder();
            builder.Populate(services);
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<FirebaseContext>().AsSelf();
            //builder.RegisterType<KhachHangRepository>().As<IKhachHangRepository>();

            builder.RegisterAssemblyTypes(typeof(KhachHangRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(typeof(LoginService).Assembly)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces();


            var container = builder.Build();


            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()); //Register WebApi Controllers

            //GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container); //Set the WebApi DependencyResolver

            // build the Autofac container

            // creating the IServiceProvider out of the Autofac container
            return new AutofacServiceProvider(container);
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseSession();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                //New Route
                routes.MapRoute(
                   name: "adminsite",
                   template: "admin-site/{controller=Home}/{action=About}/{id?}"
                );

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

            });


            //app.UseStaticFiles();

            //app.UseIdentity();

            //app.UseFacebookAuthentication(new FacebookOptions
            //{
            //    AppId = Configuration["facebook:2071355189764284"],
            //    AppSecret = Configuration["facebook:b0be32c0f33ead6a6364f0245b40bb83"],
            //    Scope = { "email" },
            //    Fields = { "name", "email" },
            //    SaveTokens = true,
            //});

           

            app.UseStaticHttpContext();
            app.UseMvc();
        }

        
    }
}
