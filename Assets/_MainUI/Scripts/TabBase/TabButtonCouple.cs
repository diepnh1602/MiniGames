[System.Serializable]
public class TabButtonCouple
{
    public TabName tabName;
    public TabBase tab;
    public SelectTabButtonBase button;
    private TabBaseManager tabBaseManager;
    public void Initialize(TabBaseManager tabBaseManager)
    {
        tab.Initialize(tabBaseManager, this);
        button.Initialize(tabBaseManager, this);
    }

    public void ShowTab()
    {
        tab.gameObject.SetActive(true);
        button.OnSelect();
        tab.OnShowTab();
    }

    public void CloseTab()
    {
        tab.gameObject.SetActive(false);
        button.OnUnSelect();
        tab.CloseTab();
    }
}
