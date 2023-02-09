using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SignalRWebpack.Hubs;
// <snippet_HubsNamespace>
using SignalRWebpack.Hubs;
// </snippet_HubsNamespace>

// <snippet_AddSignalR>
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();
// </snippet_AddSignalR>

// <snippet_FilesMiddleware>
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();
// </snippet_FilesMiddleware>

// <snippet_MapHub>
app.MapHub<ChatHub>("/hub");
// </snippet_MapHub>

app.Run();
namespace SignalRWebpack
{
    public class Program
    {
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
