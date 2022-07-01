using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(SimaxCrm.Areas.Identity.IdentityHostingStartup))]
namespace SimaxCrm.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}