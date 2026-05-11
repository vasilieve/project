using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Rocky_DataAccess.Areas.Identity.IdentityHostingStartup))]
namespace Rocky_DataAccess.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}