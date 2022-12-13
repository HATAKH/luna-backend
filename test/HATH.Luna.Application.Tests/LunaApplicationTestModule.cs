using Volo.Abp.Modularity;

namespace HATH.Luna;

[DependsOn(
    typeof(LunaApplicationModule),
    typeof(LunaDomainTestModule)
    )]
public class LunaApplicationTestModule : AbpModule
{

}
