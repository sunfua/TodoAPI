using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TodoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace TodoAPI
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddDbContext<TodoContext>(opt=>opt.UseInMemoryDatabase());            
            services.AddMvc();
            services.AddScoped<ITodoRepository, TodoRepository>();
            var connection=Configuration.GetConnectionString("BCCPDBase");// @"Server=10.57.128.14;Database=BCCP.650100;User Id=bccp;Password=123456";
            services.AddDbContext<BCCPContext>(opt=>opt.UseSqlServer(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
            Dictionary<string, string> connStrs = new Dictionary<string, string>();
            Configuration.GetSection("ConnectionStrings").Bind(connStrs);
            // connStrs.Add("650000", Configuration.GetConnectionString("650000"));
            DbContextFactory.SetConnectionString(connStrs);
            app.UseMvc();
        }
    }
}
