using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScreen : ScreenBase
{
    [SerializeField] private MenuMiniGameManager miniGameManager;
    public override void OnOpenScreen()
    {
        base.OnOpenScreen();
        SetupData();
    }
    public void SetupData()
    {
        List<MiniGameElementData> miniGameElementDatas = new List<MiniGameElementData>();
        var miniGameSOs = MiniGameManager.Instance.MiniGameSOs;

        foreach(var so in miniGameSOs)
        {
            var dt = new MiniGameElementData();

            dt.gameID = so.gameID;
            dt.gameName = so.gameName;
            dt.gameIcon = so.gameIcon;

            miniGameElementDatas.Add(dt);
        }

        miniGameManager.LoadUI(miniGameElementDatas);
    }
}
