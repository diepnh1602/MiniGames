using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMiniGameManager : MonoBehaviour
{
    [SerializeField] private RectTransform miniGameArea;
    [SerializeField] private MiniGameElementUI miniGameElementUIPref;
    [SerializeField] private float spacing;
    private List<MiniGameElementUI> miniGameElements;
    public void LoadUI(List<MiniGameElementData> datas)
    {
        miniGameElements = new List<MiniGameElementUI>();
        foreach (MiniGameElementData data in datas)
        {
            var ui = Instantiate(miniGameElementUIPref, miniGameArea);
            ui.SetData(data);
            miniGameElements.Add(ui);
        }
        int count = miniGameElements.Count;
        miniGameArea.sizeDelta =
            new Vector2(miniGameArea.sizeDelta.x, (miniGameElementUIPref.Rect.sizeDelta.y + spacing) * count);
    }
}
