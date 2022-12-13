using System;
using System.Collections.Generic;
using System.Text;
using HATH.Luna.Localization;
using Volo.Abp.Application.Services;

namespace HATH.Luna;

/* Inherit your application services from this class.
 */
public abstract class LunaAppService : ApplicationService
{
    protected LunaAppService()
    {
        LocalizationResource = typeof(LunaResource);
    }
}
