using Microsoft.EntityFrameworkCore;
using PJ_Webapp.Models;
using ResourceType = PJ_Webapp.Models.Enums.ResourceType;

namespace PJ_Webapp.Data;

public class DBServices
{
    private DataContext dataContext;
    public DBServices(DataContext _dataContext)
    {
        dataContext = _dataContext;
    }
    public void SaveData(Soldier soldier)
    {
        soldier.soldierId = Guid.NewGuid();
        dataContext.soldiers.Add(soldier);
        foreach (Skill skill in soldier.skills)
        {
            skill.skillId = Guid.NewGuid();
            skill.soldierId = soldier.soldierId;
            dataContext.skills.Add(skill);
        }
        dataContext.SaveChanges();
    }

    public void SaveData(Resource resource)
    {
        resource.resourceId = Guid.NewGuid();
        dataContext.resources.Add(resource);
        dataContext.SaveChanges();
    }

    public void SaveData(User user)
    {
        user.userID = Guid.NewGuid();
        dataContext.users.Add(user);
        dataContext.SaveChanges();
    }

    public List<Resource> GetResources()
    {
        return dataContext.resources.ToList();
    }
    public List<Soldier> GetSoldiers(User user)
    {
        return dataContext.soldiers.Include(s => s.skills).Where(s => s.playerId == user.userID).ToList();
    }

    public Skill? GetSkillById(Guid skillId)
    {
        return dataContext.skills.FirstOrDefault(s => s.skillId == skillId);
    }
    public List<User> GetUsers()
    {
        //TODO wastefull call to db, create more specific methods to access more limited data.
        return dataContext.users.Include(u => u.soldiers)
            .ThenInclude(s => s.skills)
            .ToList();
    }

    public User? GetUserByUsername(string username)
    {
        User? user = dataContext.users
            .Include(u => u.soldiers)
            .ThenInclude(s => s.skills)
            .FirstOrDefault(u => u.username == username);
        if (user != null)
        {
            dataContext.users.Attach(user);
        }
    
        return user;
    }

    public User? GetUserById(Guid userId)
    {
        return dataContext.users.FirstOrDefault(u => u.userID == userId);
    }
    public Resource GetResourceByType(ResourceType type)
    {
        Resource? result = dataContext.resources.FirstOrDefault(r => r.type == type);
        
        if (result != null)
        {
            dataContext.resources.Attach(result);
        }
        // Goes from ? to ! because all enum types are populated
        return result!;

    }
    public Resource? GetResourceByName(string name)
     {
         Resource? result = dataContext.resources.FirstOrDefault(r => r.name == name);
         if (result != null)
         {
             dataContext.resources.Attach(result);
         }

         return result;
     }
    
    public void DeleteSoldier(Soldier soldier)
    {
        dataContext.soldiers.Remove(soldier);
        dataContext.SaveChanges();
    }

    public void SaveChanges()
    {
        dataContext.SaveChanges();
    }

    public void Delete(Resource resource)
    {
        dataContext.resources.Remove(resource);
        dataContext.SaveChanges();
    }

    public void Delete(Skill skill)
    {
        dataContext.skills.Remove(skill);
        dataContext.SaveChanges();
    }

    public Soldier? GetSoldierById(Guid soldierId)
    {
        return dataContext.soldiers.FirstOrDefault(s => s.soldierId == soldierId);
    }
}