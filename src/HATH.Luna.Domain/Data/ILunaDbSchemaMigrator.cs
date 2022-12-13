using System.Threading.Tasks;

namespace HATH.Luna.Data;

public interface ILunaDbSchemaMigrator
{
    Task MigrateAsync();
}
