using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SSDeShopOnWeb.Data;

namespace SSDeShopOnWeb
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
           var host =  CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var Services = scope.ServiceProvider;
                var loggerFactory = Services.GetRequiredService<ILoggerFactory>();
                try
                {
                    var db = Services.GetRequiredService<StoreDbContext>();

                    await StoreDbSeeder.SeedAsync(db);
                }
                catch (Exception e)
                {
                    var logger = loggerFactory.CreateLogger<Program>();
                    logger.LogError(e, "An error occured while seeding the Db");
                }
            
            }

                host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
