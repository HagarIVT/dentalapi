using Dental.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Dental.Core.Repositories;
using Dental.Infrastructure.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dental
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
             
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Dental", Version = "v1" });
            });
            services.AddControllersWithViews()
      .AddNewtonsoftJson(options =>
      options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
  );
            services.AddControllers();
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"),
                        b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));


            //services.AddTransient(typeof(IDoctorRepo<>), typeof(DoctorRepo<>));
            services.AddScoped<IDoctorRepo, DoctorRepo>();
            services.AddScoped<IAppointmentRepo, AppointmentRepo>();

            //services.AddScoped(typeof(Itest<>), typeof(test<>));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Dental v1"));
            }

            app.UseHttpsRedirection();
            app.UseCors(x => x
                       .AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader());

            app.UseAuthentication();

            app.UseRouting();


            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
