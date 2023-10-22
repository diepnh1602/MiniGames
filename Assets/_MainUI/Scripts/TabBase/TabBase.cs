using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabBase : MonoBehaviour
{
    protected TabBaseManager tabBase;
    protected TabButtonCouple tabButtonCouple;
    public virtual void Initialize(TabBaseManager tabBase, TabButtonCouple tabButtonCouple)
    {
        this.tabBase = tabBase;
        this.tabButtonCouple = tabButtonCouple;
    }
    public virtual void OnShowTab() { }
    public virtual void CloseTab() { gameObject.SetActive(false); }
}
