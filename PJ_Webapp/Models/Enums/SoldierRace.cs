using System.Diagnostics;

namespace PJ_Webapp.Models.Enums;

public enum SoldierRace
{
    WHITE,
    ASIAN,
    BLACK,
    OTHER
}

public static class SoldierRaceExtensions
{
    public static string ToCustomString(this SoldierRace soldierRace)
    {
        switch (soldierRace)
        {
            case SoldierRace.WHITE:
                return "White";
            case SoldierRace.ASIAN:
                return "Asian";
            case SoldierRace.BLACK:
                return "Black";
            case SoldierRace.OTHER:
                return "Other";
            default:
                Debug.Print("\"Missing case in SoldierRace.cs, using default toString\"");
                return soldierRace.ToString(); 
        }
    }
}