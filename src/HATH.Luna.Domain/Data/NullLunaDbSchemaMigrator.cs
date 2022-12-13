using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace HATH.Luna.Data;

/* This is used if database provider does't define
 * ILunaDbSchemaMigrator implementation.
 */
public class NullLunaDbSchemaMigrator : ILunaDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
