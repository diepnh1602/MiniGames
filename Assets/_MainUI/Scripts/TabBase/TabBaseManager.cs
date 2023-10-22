using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class TabBaseManager : MonoBehaviour
{
    [SerializeField] private TabButtonCouple[] tabButtonCouples;
    public TabButtonCouple currentTabCouple { get; private set; }

    private void Awake()
    {
        Initialize();
    }


    public virtual void Initialize()
    {
        foreach(var tabCouple in tabButtonCouples)
        {
            tabCouple.Initialize(this);
        }
    }

    public virtual TabButtonCouple ShowTab(TabName tabName)
    {
        foreach (var tabCouple in tabButtonCouples)
        {
            if (tabCouple.tabName == tabName)
            {
                currentTabCouple = tabCouple;
                currentTabCouple.ShowTab();
            }
            else tabCouple.CloseTab();
        }
        return currentTabCouple;
    }
}
