using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.IO;
using System.Threading.Tasks;
using FluentEmail.Smtp;
using FluentEmail.Core;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Net;

namespace Blokitect.Api
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            if(!Directory.Exists("C:\\Blokitect\\DemoMails\\"))            
                Directory.CreateDirectory("C:\\Blokitect\\DemoMails\\");
            

            SmtpSender sender = new SmtpSender(() => new SmtpClient("localhost")
            {
                UseDefaultCredentials = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,//SpecifiedPickupDirectory,
                Credentials = new NetworkCredential("noreply@blokitect.com", string.Empty),
                EnableSsl = true,
                Host = "smtp.gmail.com",
                Port = 587,
            });

            Email.DefaultSender = sender;

            /* await Email.From("noreply@blokitect.com", name: "Blokitect")
                .To("bastiaanrogaar96@gmail.com")
                .Subject("Test")
                .Body("Hi reader, \r\r This email is considered as a sample and is meant to be ignored.")
                .SendAsync(); */

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
