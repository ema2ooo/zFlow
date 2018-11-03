using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using zFlow.Models;

[assembly: HostingStartup(typeof(zFlow.Areas.Identity.IdentityHostingStartup))]
namespace zFlow.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<zFlowContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("zFlowContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<zFlowContext>();
            });
        }
    }
}