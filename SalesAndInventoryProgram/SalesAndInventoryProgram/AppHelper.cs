using SalesAndInventoryProgram.Auth;
using SalesAndInventoryProgram.Data;

internal static class AppHelper
{

    public static AuthContext auth = new();

    public static ShopContext db = new();
}