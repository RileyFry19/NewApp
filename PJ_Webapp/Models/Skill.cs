using System.ComponentModel.DataAnnotations;
using PJ_Webapp.Models.Enums;

namespace PJ_Webapp.Models;

public class Skill
{
    
    // DB Properties
    [Key]
    public Guid skillId { get; set; }
    public Guid soldierId { get; set; }
    public Soldier soldier { get; set; }
    public Skill()
    {
        
    }
    // Normal Properties
    public SoldierSkill name { get; set; } //USED IN DB
    public int level { get; set; } //USED IN DB
    
    public Skill(SoldierSkill name)
    {
        this.name = name;
        level = 0;
    }

    public int GetUpgradeCost()
    {
        if (name.GetCategory() == "Artisan Skills")
        {
            return 1;
        }
        // if field skill
        return level + 1;
    }
}