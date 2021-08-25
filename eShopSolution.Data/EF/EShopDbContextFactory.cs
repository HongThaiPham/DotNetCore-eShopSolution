using System;
using System.IO;
using eShopSolution.Utilities.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace eShopSolution.Data.EF
{
    public class EShopDbContextFactory : IDesignTimeDbContextFactory<EShopDBContext>
    {

        public EShopDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            //string mySqlConnectionStr = "server=103.81.84.215; port=3306; database=eShopSolution; user=eshop; password=123456789; Persist Security Info=False; Connect Timeout=300";
            string mySqlConnectionStr = configuration.GetConnectionString(SystemConstants.MainConnectionString);
            var optionsBuilder = new DbContextOptionsBuilder<EShopDBContext>();
            optionsBuilder.UseMySql(mySqlConnectionStr, ServerVersion.AutoDetect(mySqlConnectionStr));
            return new EShopDBContext(optionsBuilder.Options);
        }
    }
}
