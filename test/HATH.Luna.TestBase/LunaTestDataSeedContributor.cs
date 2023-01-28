using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace HATH.Luna;

public class LunaTestDataSeedContributor : IDataSeedContributor, ITransientDependency
{
    private readonly TestBaseProvider _testBaseProvider;
    public Task SeedAsync(DataSeedContext context)
    {
        /* Seed additional test data... */
        _testBaseProvider.SeedDataAsync();
        return Task.CompletedTask;
    }
}
