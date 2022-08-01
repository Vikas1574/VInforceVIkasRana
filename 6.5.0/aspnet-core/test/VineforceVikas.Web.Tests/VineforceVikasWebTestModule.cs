using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using VineforceVikas.EntityFrameworkCore;
using VineforceVikas.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace VineforceVikas.Web.Tests
{
    [DependsOn(
        typeof(VineforceVikasWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class VineforceVikasWebTestModule : AbpModule
    {
        public VineforceVikasWebTestModule(VineforceVikasEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VineforceVikasWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(VineforceVikasWebMvcModule).Assembly);
        }
    }
}