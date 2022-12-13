using HATH.Luna.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace HATH.Luna.Permissions;

public class LunaPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(LunaPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(LunaPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<LunaResource>(name);
    }
}
