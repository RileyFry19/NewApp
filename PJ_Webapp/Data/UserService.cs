using PJ_Webapp.Models;

namespace PJ_Webapp.Data;

public class UserService
{
    public User? LoggedInUser { get; set; }
    public UserService()
    {
        
    }

    public event Action OnChange;

    public void UserChanged()
    {
        OnChange?.Invoke();
    }

}