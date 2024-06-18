using PJ_Webapp.Models;

namespace PJ_Webapp.Data;

public class PanelManager
{
    public Soldier currentSoldier { get; set; }
    public event Action OnChange;

    public enum PanelType
    {
        NONE,
        SKILL_POINT_SPEND_PANEL,
        ROLE_ASSIGN_PANEL,
        ATTRIBUTE_SPEND_PANEL
    }

    private PanelType currentPanel;

    public void OpenPanel(PanelType panel, Soldier soldier)
    {
        currentPanel = panel;
        currentSoldier = soldier;
        OnChange?.Invoke();
    }

    public void ClosePanel()
    {
        currentPanel = PanelType.NONE;
        currentSoldier = null;
        OnChange?.Invoke();
    }
    
    public PanelType GetCurrentPanel()
    {
        return currentPanel;
    }

    public bool IsPanelOpen(PanelType panel)
    {
        return currentPanel == panel;
    }

    public void UiUpdated()
    {
        OnChange?.Invoke();
    }
}