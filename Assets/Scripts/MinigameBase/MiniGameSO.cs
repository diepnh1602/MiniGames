using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

[CreateAssetMenu(fileName ="MiniGameSO" , menuName = "Datas/MiniGameSO")]
public class MiniGameSO : ScriptableObject
{
    public int gameID;
    public string gameName;
    public Sprite gameIcon;
    public AssetReference gamePrefabRef;
}
