using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectTabButtonBase : MonoBehaviour
{
    [SerializeField] private Button btn;
    protected TabBaseManager tabBaseManager;
    protected TabButtonCouple tabButtonCouple;
    public void Initialize(TabBaseManager tabBaseManager, TabButtonCouple tabButtonCouple)
    {
        this.tabBaseManager = tabBaseManager;
        this.tabButtonCouple = tabButtonCouple;
        btn.onClick.AddListener(OnClickButton);
    }
    public virtual void OnSelect() { }
    public virtual void OnUnSelect() { }
    public virtual void OnClickButton()
    {
        tabBaseManager.ShowTab(tabButtonCouple.tabName);
    }
}
