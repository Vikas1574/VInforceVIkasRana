using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using VineforceVikas.Configuration;

namespace VineforceVikas.Web.Host.Startup
{
    [DependsOn(
       typeof(VineforceVikasWebCoreModule))]
    public class VineforceVikasWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public VineforceVikasWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VineforceVikasWebHostModule).GetAssembly());
        }
    }
}
