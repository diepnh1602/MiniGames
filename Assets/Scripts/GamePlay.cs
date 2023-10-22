using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : Singleton<GamePlay>
{
    public void LoadMiniGame(int gameID)
    {
        var gameSO = MiniGameManager.Instance.GetMiniGameSO(gameID);
    }
}
