using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPupolation(IApplicationBuilder appBuilder)
        {
            using (var serviceScope = appBuilder.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }   

        private static void SeedData(AppDbContext context)
        {

            if(!context.Platforms.Any())
            {
                System.Console.WriteLine(" --> Seeding data...");
                context.Platforms.AddRange(
                    new Platform(){ Name = "DotNet", Publisher = "Microsoft", Cost="Free" },
                    new Platform(){ Name = "Sql Server Express", Publisher = "Microsoft", Cost="Free" },
                    new Platform(){ Name = "Kubernetes", Publisher = "Cloud Native Computing Foundation", Cost="Free" }
                    
                );
                
                context.SaveChanges();

            }else
            {
                System.Console.WriteLine("--> we already have data!");
            }

        }
    }
}