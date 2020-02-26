using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Sitecore.Framework.Runtime.Configuration;

namespace GitVadim.Sitecore.NetCore.IdentityServer.AzureB2C
{
    public class ConfigureSitecore
    {
        private readonly ILogger<ConfigureSitecore> _logger;

        public ConfigureSitecore(ISitecoreConfiguration scConfig, ILogger<ConfigureSitecore> logger)
        {
        }

        public void ConfigureServices(IServiceCollection services)
        {

        }
    }
}
