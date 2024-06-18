namespace PJ_Webapp.Models.Enums
{
    public enum SoldierSkill
    {
        // Field Skills
        ADMINISTER,
        DRIVE,
        FIX,
        HEAL,
        KNOW,
        NOTICE,
        MANIPULATE,
        PERFORM,
        SNEAK,
        SURVIVE,
        HACK,
        LINGUISTICS,

        // Artisan Skills
        SCAVENGE,
        MINE,
        SKIN,
        HERBALISM,
        SOUL_COLLECTION,
        DIMENSIONAL_MANIPULATION,
        GUNSMITH,
        BLACKSMITH,
        ARMORSMITHING,
        ALCHEMY,
        DIMENSIONS,
        ROBOTICS,
        ENCHANTMENT,
        RESEARCH,
        RIFT_ANALYSIS,
        TANNING,
        SMELTING,
        REHABILITATION
    }

    public static class SkillExtensions
    {
        public static string ToCustomString(this SoldierSkill soldierSkill)
        {
            // Implement custom string logic for both categories
            switch (soldierSkill)
            {
                // Field Skills
                case SoldierSkill.ADMINISTER:
                    return "Administer";
                case SoldierSkill.DRIVE:
                    return "Drive";
                case SoldierSkill.FIX:
                    return "Fix";
                case SoldierSkill.HEAL:
                    return "Heal";
                case SoldierSkill.KNOW:
                    return "Know";
                case SoldierSkill.NOTICE:
                    return "Notice";
                case SoldierSkill.MANIPULATE:
                    return "Manipulate";
                case SoldierSkill.PERFORM:
                    return "Perform";
                case SoldierSkill.SNEAK:
                    return "Sneak";
                case SoldierSkill.SURVIVE:
                    return "Survive";
                case SoldierSkill.HACK:
                    return "Hack";
                case SoldierSkill.LINGUISTICS:
                    return "Linguistics";

                // Artisan Skills
                case SoldierSkill.SCAVENGE:
                    return "Scavenge";
                case SoldierSkill.MINE:
                    return "Mine";
                case SoldierSkill.SKIN:
                    return "Skin";
                case SoldierSkill.HERBALISM:
                    return "Herbalism";
                case SoldierSkill.SOUL_COLLECTION:
                    return "Soul Collection";
                case SoldierSkill.DIMENSIONAL_MANIPULATION:
                    return "Dimensional Manipulation";
                case SoldierSkill.GUNSMITH:
                    return "Gunsmith";
                case SoldierSkill.BLACKSMITH:
                    return "Blacksmith";
                case SoldierSkill.ARMORSMITHING:
                    return "Armor Smithing";
                case SoldierSkill.ALCHEMY:
                    return "Alchemy";
                case SoldierSkill.DIMENSIONS:
                    return "Dimensions";
                case SoldierSkill.ROBOTICS:
                    return "Robotics";
                case SoldierSkill.ENCHANTMENT:
                    return "Enchantment";
                case SoldierSkill.RESEARCH:
                    return "Research";
                case SoldierSkill.RIFT_ANALYSIS:
                    return "Rift Analysis";
                case SoldierSkill.TANNING:
                    return "Tanning";
                case SoldierSkill.SMELTING:
                    return "Smelting";
                case SoldierSkill.REHABILITATION:
                    return "Rehabilitation";

                default:
                    return soldierSkill.ToString();
            }
        }

        public static string GetCategory(this SoldierSkill soldierSkill)
        {
            switch (soldierSkill)
            {
                // Field Skills
                case SoldierSkill.ADMINISTER:
                case SoldierSkill.DRIVE:
                case SoldierSkill.FIX:
                case SoldierSkill.HEAL:
                case SoldierSkill.KNOW:
                case SoldierSkill.NOTICE:
                case SoldierSkill.MANIPULATE:
                case SoldierSkill.PERFORM:
                case SoldierSkill.SNEAK:
                case SoldierSkill.SURVIVE:
                case SoldierSkill.HACK:
                case SoldierSkill.LINGUISTICS:
                    return "Field Skills";

                // Artisan Skills
                case SoldierSkill.SCAVENGE:
                case SoldierSkill.MINE:
                case SoldierSkill.SKIN:
                case SoldierSkill.HERBALISM:
                case SoldierSkill.SOUL_COLLECTION:
                case SoldierSkill.DIMENSIONAL_MANIPULATION:
                case SoldierSkill.GUNSMITH:
                case SoldierSkill.BLACKSMITH:
                case SoldierSkill.ARMORSMITHING:
                case SoldierSkill.ALCHEMY:
                case SoldierSkill.DIMENSIONS:
                case SoldierSkill.ROBOTICS:
                case SoldierSkill.ENCHANTMENT:
                case SoldierSkill.RESEARCH:
                case SoldierSkill.RIFT_ANALYSIS:
                case SoldierSkill.TANNING:
                case SoldierSkill.SMELTING:
                case SoldierSkill.REHABILITATION:
                    return "Artisan Skills";

                default:
                    return "Unknown Category";
            }
        }
    }
}