using UnityEngine;
using UnityEngine.UI;

public class MainTabSelectButton : SelectTabButtonBase
{
    [SerializeField] private Image imgSelected;

    public override void OnSelect()
    {
        base.OnSelect();
        imgSelected.gameObject.SetActive(true);
    }

    public override void OnUnSelect()
    {
        base.OnUnSelect();
        imgSelected.gameObject.SetActive(false);
    }
}
