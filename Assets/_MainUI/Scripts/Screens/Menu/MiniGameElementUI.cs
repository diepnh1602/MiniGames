using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MiniGameElementUI : MonoBehaviour
{
    [SerializeField] private RectTransform rect;
    [SerializeField] private TextMeshProUGUI txtGameName;
    [SerializeField] private Image gameIcon;
    [SerializeField] private Button btnSelectGame;
    public RectTransform Rect => rect;
    private int gameID;

    private void Awake()
    {
        btnSelectGame.onClick.AddListener(() =>
        {

        });
    }

    public void SetData(MiniGameElementData data)
    {
        this.gameID = data.gameID;
        txtGameName.text = data.gameName;
        gameIcon.sprite = data.gameIcon;
    }
}

public class MiniGameElementData
{
    public int gameID;
    public string gameName;
    public Sprite gameIcon;
}
