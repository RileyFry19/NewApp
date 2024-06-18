

namespace PJ_Webapp.Models;
    public enum ResourceCategory
    {
        ALCHEMY,
        TANNING,
        MANA_STONES,
        DIMENSIONAL,
        ORE,
        RESEARCH,
        MECHANISMS,
        SOUL_SHARDS,
        OTHER
    }

    public static class ResourceCategoryExtensions
    {
        public static string ToCustomString(this ResourceCategory resourceCategory)
        {
            return resourceCategory.ToString().Replace("_", " ");
        }

        public static string GetCategoryColor(this ResourceCategory resourceCategory)
        {
            switch (resourceCategory)
            {
                case ResourceCategory.ALCHEMY:
                    return "bg-danger";
                case ResourceCategory.TANNING:
                    return "bg-warning";
                case ResourceCategory.MANA_STONES:
                    return "bg-info";
                case ResourceCategory.DIMENSIONAL:
                    return "bg-success";
                case ResourceCategory.ORE:
                    return "bg-secondary";
                case ResourceCategory.RESEARCH:
                    return "bg-primary";
                case ResourceCategory.MECHANISMS:
                    return "bg-dark";
                case ResourceCategory.SOUL_SHARDS:
                    return "bg-light";
                case ResourceCategory.OTHER:
                default:
                    return "bg-white";
            }
        }
        
        
    }