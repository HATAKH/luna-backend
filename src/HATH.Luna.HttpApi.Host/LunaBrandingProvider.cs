using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace HATH.Luna;

[Dependency(ReplaceServices = true)]
public class LunaBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Luna";
}
