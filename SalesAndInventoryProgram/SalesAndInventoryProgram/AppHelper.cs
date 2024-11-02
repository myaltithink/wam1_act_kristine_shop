using SalesAndInventoryProgram;
using SalesAndInventoryProgram.Auth;
using SalesAndInventoryProgram.Data;
using SalesAndInventoryProgram.Data.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;

internal static class AppHelper
{

    public static AuthContext auth = new();

    public static ShopContext db = new();

    private static Regex EmptyRegex = new(@"^\s*$");

    public static string ActiveStatus = "Active";

    public static string DisableStatus = "Disabled";

    public static UpdatePassword UpdatePassForm = null;

    public static Encryption Encryption = new();

    public static Product SelectedProduct = null;

    public static List<SaleItem> SalesItem = new();

    public static bool IsEmpty(string value)
    {
        return EmptyRegex.IsMatch(value);
    }


    public static void CloseUpdatePassForm()
    {
        if(UpdatePassForm != null)
        {
            UpdatePassForm.Close();
        }
    }
}