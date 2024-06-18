using System.Diagnostics;

namespace PJ_Webapp.Models.Enums;

public enum SoldierClass
{
    GRUNT,
    HEAVY,
    ASSAULT,
    SHARPSHOOTER,
    SUPPORT,
    ADEPT,
    ARTISAN
}
public static class SoldierClassExtensions
{
    public static string ToCustomString(this SoldierClass soldierClass)
    {
        switch (soldierClass)
        {
            case SoldierClass.HEAVY:
                return "Heavy";
            case SoldierClass.ASSAULT:
                return "Assault";
            case SoldierClass.SHARPSHOOTER:
                return "Sharpshooter";
            case SoldierClass.SUPPORT:
                return "Support";
            case SoldierClass.ADEPT:
                return "Adept";
            case SoldierClass.ARTISAN:
                return "Artisan";
            case SoldierClass.GRUNT:
                return "Grunt";
            default:
                Debug.Print("\"Missing case in SoldierClass.cs, using default toString\"");
                return soldierClass.ToString();
        }
    }
}