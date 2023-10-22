using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class UIManager : Singleton<UIManager>
{
    [Header("*******  Screen *******")]
    [SerializeField] private AssetLabelReference screenLabel;
    [SerializeField] private List<ScreenBase> screens = new List<ScreenBase>();
    [Header("*******  Popup *******")]
    [SerializeField] private AssetLabelReference popupLabel;
    [SerializeField] private List<PopupBase> popups = new List<PopupBase>();

    public bool IsLoadPrefabSuccess;
    private bool isLoadScreenSuccess;
    private bool isLoadPopupSuccess;
    protected override void Awake()
    {
        base.Awake();
        GameManager.OnLoadConfig += LoadPrefabs;
    }

    public void LoadPrefabs()
    {
        StartCoroutine(OnLoadPrefabs());
    }
    private IEnumerator OnLoadPrefabs()
    {
        LoadScreenPrefabs();
        LoadPopupPrefabs();
        yield return new WaitUntil(() => isLoadPopupSuccess && isLoadScreenSuccess);
        IsLoadPrefabSuccess = true;
    }

    private void LoadScreenPrefabs()
    {
        Addressables.LoadAssetsAsync<GameObject>(screenLabel.labelString, null).Completed += value =>
        {
            if(value.IsDone && value.Result != null)
            {
                foreach (GameObject sc in value.Result)
                {
                    screens.Add(sc.GetComponent<ScreenBase>());
                }
            }
            isLoadScreenSuccess = true;
        };
    }

    private void LoadPopupPrefabs()
    {
        Addressables.LoadAssetsAsync<GameObject>(popupLabel.labelString, null).Completed += value =>
        {
            if(value.IsDone && value.Result != null)
            {
                foreach (GameObject sc in value.Result)
                {
                    popups.Add(sc.GetComponent<PopupBase>());
                }
            }
            isLoadPopupSuccess = true;
        };
    }
}
