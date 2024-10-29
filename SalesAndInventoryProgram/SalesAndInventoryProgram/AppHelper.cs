using SalesAndInventoryProgram.Auth;
using SalesAndInventoryProgram.Data;
using System.Text.RegularExpressions;

internal static class AppHelper
{

    public static AuthContext auth = new();

    public static ShopContext db = new();

    private static Regex EmptyRegex = new(@"^\s*$");

    public static bool IsEmpty(string value)
    {
        return EmptyRegex.IsMatch(value);
    }

}