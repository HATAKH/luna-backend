using HATH.Luna.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace HATH.Luna.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(LunaEntityFrameworkCoreModule),
    typeof(LunaApplicationContractsModule)
    )]
public class LunaDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
