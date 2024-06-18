using System.ComponentModel.DataAnnotations;
using PJ_Webapp.Models.Enums;

namespace PJ_Webapp.Models;

public class Resource
{
    [Key]
    public Guid resourceId { get; set; }
    public ResourceType type { get; set; }
    public string name { get; set; }
    public int amount { get; set; }
    public ResourceCategory category { get; set; }

    public Resource()
    {
        
    }

    public Resource(string name, int amt)
    {
        this.name = name;
        amount = amt;
        this.category = ResourceCategory.OTHER;
    }

    public Resource(ResourceType type, int amount)
    {
        this.type = type;
        this.name = type.ToCustomString();
        this.amount = amount;
        this.category = type.Category();
    }
}