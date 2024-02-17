using gms.common.Enums;

namespace gms.common.Constants;

public static class PermissionsConstants
{
    public static string Permission = "Permission";
    public static string Permissions = "Permissions";
    public static List<string> GeneratePermissionList(string module)
    {
        return new List<string>()
        {
            $"{Permissions}.{module}.{PermissionsEnum.View}",
            $"{Permissions}.{module}.{PermissionsEnum.Create}",
            $"{Permissions}.{module}.{PermissionsEnum.Edit}",
            $"{Permissions}.{module}.{PermissionsEnum.Delete}"
        };
    }
}
