using Volo.Abp.Settings;

namespace HATH.Luna.Settings;

public class LunaSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(LunaSettings.MySetting1));
    }
}
