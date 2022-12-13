using HATH.Luna.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace HATH.Luna.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class LunaController : AbpControllerBase
{
    protected LunaController()
    {
        LocalizationResource = typeof(LunaResource);
    }
}
