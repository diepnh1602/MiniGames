using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class MiniGameManager : Singleton<MiniGameManager>
{
    [SerializeField] private AssetLabelReference miniGameLabel;
    [SerializeField] private List<MiniGameSO> miniGames;
    public bool IsLoadSuccess;
    protected override void Awake()
    {
        base.Awake();
        GameManager.OnLoadConfig += LoadMiniGameSO;
    }


    //Load Data
    private void LoadMiniGameSO()
    {
        Addressables.LoadAssetsAsync<MiniGameSO>(miniGameLabel.labelString, null).Completed += value =>
        {
            foreach (MiniGameSO so in value.Result)
            {
                miniGames.Add(so);
            }
            IsLoadSuccess = true;
        };
    }

    public MiniGameSO GetMiniGameSO(int gameID)
    {
        return miniGames.Find(x => x.gameID == gameID);
    }

    public List<MiniGameSO> MiniGameSOs => miniGames;
}
