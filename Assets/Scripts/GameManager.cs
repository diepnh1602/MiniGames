using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static Action OnLoadConfig;
    public static Action OnLoadGameResourceSuccess;

    private void Start()
    {
        LoadConfigGame();
    }

    public void LoadConfigGame()
    {
        StartCoroutine(LoadConfig());
    }

    private IEnumerator LoadConfig()
    {
        OnLoadConfig?.Invoke();
        yield return new WaitUntil(() => MiniGameManager.Instance.IsLoadSuccess);
        yield return new WaitUntil(() => UIManager.Instance.IsLoadPrefabSuccess);
        OnLoadGameResourceSuccess?.Invoke();
    }
}
