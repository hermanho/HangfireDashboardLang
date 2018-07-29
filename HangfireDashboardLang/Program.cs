using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace HangfireDashboardLang
{
    public class Program
    {
        public static void Main(string[] args)
        {
#if NETCOREAPP2_0 || NETCOREAPP2_1
            CreateWebHostBuilder(args).Build().Run();
#elif NETCOREAPP1_1
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
#endif
        }

#if NETCOREAPP2_0 || NETCOREAPP2_1
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
#endif
    }
}
