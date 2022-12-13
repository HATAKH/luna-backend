using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace HATH.Luna.Pages;

public class Index_Tests : LunaWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
