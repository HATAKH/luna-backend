using HATH.Luna.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace HATH.Luna.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class LunaPageModel : AbpPageModel
{
    protected LunaPageModel()
    {
        LocalizationResourceType = typeof(LunaResource);
    }
}
