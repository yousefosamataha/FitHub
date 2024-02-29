using gms.common.Enums;

namespace gms.common.Constants;

public static class PermissionsConstants
{
    public const string Permission = "Permission";
    public const string Permissions = "Permissions";
    public static List<string> GeneratePermissionList(string module)
    {
        List<string> PermissionsList = new();
        foreach (var permission in Enum.GetValues(typeof(PermissionsEnum)))
        {
            PermissionsList.Add($"{Permissions}.{module}.{permission}");
        }
        return PermissionsList;
    }
    public static List<string> GenerateAllPermissionsList()
    {
        List<string> PermissionsList = new();
        foreach (var module in Enum.GetValues(typeof(ModulesEnum)))
        {
            foreach (var permission in Enum.GetValues(typeof(PermissionsEnum)))
            {
                PermissionsList.Add($"{Permissions}.{module}.{permission}");
            }
        }
        return PermissionsList;
    }
}
