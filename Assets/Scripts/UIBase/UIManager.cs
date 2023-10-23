using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class UIManager : Singleton<UIManager>
{
    [Header("*******  UI *******")]
    [SerializeField] private Transform UIArea;
    [SerializeField] private AssetLabelReference uiLabel;
    [SerializeField] private List<UIBase> uis = new List<UIBase>();
    [SerializeField] private UIBase Current;
    public bool IsLoadPrefabSuccess;
    protected override void Awake()
    {
        base.Awake();
        GameManager.OnLoadConfig += LoadPrefabs;
        GameManager.OnLoadGameResourceSuccess += Initialize;
    }

    public void Initialize()
    {
        OpenUI(UIName.MAIN);
    }

    public void LoadPrefabs()
    {
        Addressables.LoadAssetsAsync<GameObject>(uiLabel.labelString, null).Completed += value =>
        {
            if (value.IsDone && value.Result != null)
            {
                foreach (GameObject sc in value.Result)
                {
                    uis.Add(sc.GetComponent<UIBase>());
                }
                IsLoadPrefabSuccess = true;
            }
        };
    }

    public UIBase OpenUI(UIName uiName)
    {
        Debug.Log(uiName);
        CloseCurrentUI();
        var uiPref = uis.Find(x => x.uiName == uiName);
        Current = Instantiate(uiPref, UIArea);
        Current.OnOpenUI();
        return Current;
    }

    public void CloseCurrentUI()
    {
        if (Current == null) return;
        Current.OnCloseUI();
        Destroy(Current.gameObject);
        Current = null;
    }
}
