﻿using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ServiceStack;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "MVC Client";

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(builder =>
                {
                    builder.UseModularStartup<Startup>();
                });
    }
}
