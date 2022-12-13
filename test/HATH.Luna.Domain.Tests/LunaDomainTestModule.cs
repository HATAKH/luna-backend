using HATH.Luna.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace HATH.Luna;

[DependsOn(
    typeof(LunaEntityFrameworkCoreTestModule)
    )]
public class LunaDomainTestModule : AbpModule
{

}
