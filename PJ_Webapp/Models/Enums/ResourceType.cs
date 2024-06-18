namespace PJ_Webapp.Models.Enums;

public enum ResourceType
{
    // ALCHEMY
    IRONWOOD, 
    BLIZZARD_LILIES,
    FURNACE_MUSHROOMS,
    BERRIES_OF_JOY,
    // TANNING
    LIGHT_HIDE,
    LIGHT_LEATHER,
    LIGHT_CARAPACE,
    CURED_CARAPACE,
    // MECHANISMS
    NANO_SERVOS,
    PANOPTICON_SENSORS,
    // MANA STONES
    T1_MANA,
    T2_MANA,
    T3_MANA,
    T4_MANA,
    // ORE
    FRACTAL_QUARTZ,
    SENTIENT_STEEL,
    //SOUL SHARDS
    SOUL_SHADOW,
    FRACTURED_SOUL,
    // DIMENSIONAL
    DIMENSIONAL_ANOMALY,
    // RESEARCH
    TECH_SHARD,
    GRIMOIRE,
    TECH_RESEARCH,
    MAGIC_RESEARCH
}

public static class ResourceTypeExtensions
{
    public static string ToCustomString(this ResourceType resourceType)
    {
        return resourceType switch
        {
            ResourceType.IRONWOOD => "Ironwood",
            ResourceType.BLIZZARD_LILIES => "Blizzard Lilies",
            ResourceType.FURNACE_MUSHROOMS => "Furnace Mushrooms",
            ResourceType.BERRIES_OF_JOY => "Berries of Joy",
            ResourceType.LIGHT_HIDE => "Light Hide",
            ResourceType.LIGHT_LEATHER => "Light Leather",
            ResourceType.LIGHT_CARAPACE => "Light Carapace",
            ResourceType.CURED_CARAPACE => "Cured Carapace",
            ResourceType.NANO_SERVOS => "Nano Servos",
            ResourceType.PANOPTICON_SENSORS => "Panopticon Sensors",
            ResourceType.T1_MANA => "T1 Mana",
            ResourceType.T2_MANA => "T2 Mana",
            ResourceType.T3_MANA => "T3 Mana",
            ResourceType.T4_MANA => "T4 Mana",
            ResourceType.FRACTAL_QUARTZ => "Fractal Quartz",
            ResourceType.SENTIENT_STEEL => "Sentient Steel",
            ResourceType.SOUL_SHADOW => "Soul Shadow",
            ResourceType.FRACTURED_SOUL => "Fractured Soul",
            ResourceType.DIMENSIONAL_ANOMALY => "Dimensional Anomaly",
            ResourceType.TECH_SHARD => "Tech Shard",
            ResourceType.GRIMOIRE => "Grimoire",
            ResourceType.TECH_RESEARCH => "Tech Research",
            ResourceType.MAGIC_RESEARCH => "Magic Research",
            _ => "Missing toString in ResourceType.cs"
        };
    }

    public static ResourceCategory Category(this ResourceType resourceType)
    {
        switch (resourceType)
        {
            // ALCHEMY
            case ResourceType.IRONWOOD:
            case ResourceType.BLIZZARD_LILIES:
            case ResourceType.FURNACE_MUSHROOMS:
            case ResourceType.BERRIES_OF_JOY:
                return ResourceCategory.ALCHEMY;

            // TANNING
            case ResourceType.LIGHT_HIDE:
            case ResourceType.LIGHT_LEATHER:
            case ResourceType.LIGHT_CARAPACE:
            case ResourceType.CURED_CARAPACE:
                return ResourceCategory.TANNING;

            // MECHANISMS
            case ResourceType.NANO_SERVOS:
            case ResourceType.PANOPTICON_SENSORS:
                return ResourceCategory.MECHANISMS;

            // MANA STONES
            case ResourceType.T1_MANA:
            case ResourceType.T2_MANA:
            case ResourceType.T3_MANA:
            case ResourceType.T4_MANA:
                return ResourceCategory.MANA_STONES;

            // ORE
            case ResourceType.FRACTAL_QUARTZ:
            case ResourceType.SENTIENT_STEEL:
                return ResourceCategory.ORE;

            // SOUL SHARDS
            case ResourceType.SOUL_SHADOW:
            case ResourceType.FRACTURED_SOUL:
                return ResourceCategory.SOUL_SHARDS;

            // DIMENSIONAL
            case ResourceType.DIMENSIONAL_ANOMALY:
                return ResourceCategory.DIMENSIONAL;

            // RESEARCH
            case ResourceType.TECH_SHARD:
            case ResourceType.GRIMOIRE:
            case ResourceType.TECH_RESEARCH:
            case ResourceType.MAGIC_RESEARCH:
                return ResourceCategory.RESEARCH;

            default:
                throw new ArgumentOutOfRangeException(nameof(resourceType), resourceType, null);
        }
    }
}