using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Identity;

namespace HATH.Luna;

public class TestBaseProvider : LunaTestBase<LunaTestBaseModule>
{
    private readonly IdentityUserManager _identityUserManager;
    private readonly IdentityRoleManager _identityRoleManager;
    private List<IdentityUser> _users;

    // TODO: Add more fields here like student and personel

    public TestBaseProvider()
    {
        _users = new List<IdentityUser>();
        _identityUserManager = GetRequiredService<IdentityUserManager>();
        _identityRoleManager = GetRequiredService<IdentityRoleManager>();
    }
    public async Task SeedDataAsync()
    {
        // Seed Data
    }
}
