using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Users.Data;

[assembly: HostingStartup(typeof(Users.Areas.Identity.IdentityHostingStartup))]
namespace Users.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            
        }
        public void Configure(IWebHostBuilder builder, IApplicationBuilder app)
        {
            //builder.ConfigureServices((context, services) => {
            //    services.AddDbContext<UsersContext>(options =>
            //        options.UseSqlServer(
            //            context.Configuration.GetConnectionString("UsersContextConnection")));

            //    services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //        .AddEntityFrameworkStores<UsersContext>();
            //});

            app.UseAuthentication();
            app.UseAuthorization();
        }

       
    }
}