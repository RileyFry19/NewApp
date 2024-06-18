using System.Diagnostics;

namespace PJ_Webapp.Models.Enums;

public enum Loyalty
{
    SYMPATHIZER,
    NA,
    UN_PATRIOTIC,
    SLIGHTLY_PATRIOTIC,
    PATRIOTIC,
    STRONGLY_PATRIOTIC,
    NATIONALIST,
    ULTRA_NATIONALIST,
}

public static class LoyaltyExtensions
{
    public static string ToCustomString(this Loyalty loyalty)
    {
        switch (loyalty)
        {
            case Loyalty.SYMPATHIZER:
                return "Sympathizer";
            case Loyalty.NA:
                return "Player";
            case Loyalty.UN_PATRIOTIC:
                return "Un-patriotic";
            case Loyalty.SLIGHTLY_PATRIOTIC:
                return "Slightly Patriotic";
            case Loyalty.PATRIOTIC:
                return "Patriotic";
            case Loyalty.STRONGLY_PATRIOTIC:
                return "Strongly Patriotic";
            case Loyalty.NATIONALIST:
                return "Nationalist";
            case Loyalty.ULTRA_NATIONALIST:
                return "Ultra Nationalist";
            default:
                Debug.Print("Missing case in Loyalty.cs, using default toString");
                return loyalty.ToString();
        }
    }
}