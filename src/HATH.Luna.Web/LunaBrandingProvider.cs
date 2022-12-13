using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace HATH.Luna.Web;

[Dependency(ReplaceServices = true)]
public class LunaBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Luna";
}
