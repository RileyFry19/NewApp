namespace PJ_Webapp.Models.Enums;

public enum SoldierHealthStatus
{
    HEALTHY,
    KNEE_SHATTERED,
    HAND_CUT_OFF,
    LEG_CUT_OFF,
    BACK_BROKEN,
    JAW_SHATTERED,
    LOST,
    GUT_WOUND,
    DEAD
    
}

public static class SoldierHealthStatusExtensions
{
    public static string ToCustomString(this SoldierHealthStatus health)
    {
        return health switch
        {
            SoldierHealthStatus.HEALTHY => "Healthy",
            SoldierHealthStatus.KNEE_SHATTERED => "Knee Shattered",
            SoldierHealthStatus.HAND_CUT_OFF => "Hand Cut Off",
            SoldierHealthStatus.LEG_CUT_OFF => "Leg Cut Off",
            SoldierHealthStatus.BACK_BROKEN => "Back Broken",
            SoldierHealthStatus.JAW_SHATTERED => "Jaw Shattered",
            SoldierHealthStatus.LOST => "Lost",
            SoldierHealthStatus.DEAD => "Dead",
            SoldierHealthStatus.GUT_WOUND => "Gut Wound",
            _ => "Oops health status unknown!"
        };
    }

    public static string ToBadge(this SoldierHealthStatus health)
    {
        return health switch
        {
            SoldierHealthStatus.HEALTHY => "badge text-bg-success",
            SoldierHealthStatus.DEAD => "badge text-bg-danger",
            SoldierHealthStatus.LOST => "badge text-bg-danger",
            _ => "badge text-bg-warning"
        };
    }
}
