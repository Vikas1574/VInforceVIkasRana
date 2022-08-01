using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using VineforceVikas.Authorization;

namespace VineforceVikas
{
    [DependsOn(
        typeof(VineforceVikasCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class VineforceVikasApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<VineforceVikasAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(VineforceVikasApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
