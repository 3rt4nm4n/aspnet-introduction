using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test1
{
    public class Program
    {

        /*DEPENDENCIES
         * Formerly there was reference part now in .NET Core it is known as "Dependencies"
         * All libraries, frameworks etc in application are called Dependencies
         * Model View Controller
         * Model : Database
         * View : Front End
         * Controller : Back End / Manager
         * Controller manages all of the operations
         * MVC is similar to N-tier architecture in C#
         * Controllers are like classes
         * Actions are like methods
         */
        
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
