using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBase : MonoBehaviour
{
    public UIName uiName;
    [Header("******* Screen *******")]
    [SerializeField] private List<ScreenBase> screens = new List<ScreenBase>();

    [Header("******* Popup *******")]
    [SerializeField] private List<PopupBase> popups = new List<PopupBase>();

    public virtual void OnOpenUI()
    {
        CloseAllPopup();
        CloseAllScreen();
    }


    public virtual void OnCloseUI()
    {

    }

    public ScreenBase GetScreen(ScreenName screenName)
    {
        return screens.Find(x => x.ScreenName == screenName);
    }

    public PopupBase GetPopup(PopupName popupName)
    {
        return popups.Find(x => x.PopupName == popupName);
    }
    public virtual ScreenBase ShowScreen(ScreenName screenName)
    {
        var screen = GetScreen(screenName);
        screen.gameObject.SetActive(true);
        screen.OnOpenScreen();
        return screen;
    }
    public virtual void CloseScreen(ScreenName screenName)
    {
        var screen = GetScreen(screenName);
        screen.gameObject.SetActive(false);
        screen.OnCloseScreen();
    }

    public virtual PopupBase ShowPopup(PopupName popupName)
    {
        var popup = GetPopup(popupName);
        popup.gameObject.SetActive(true);
        popup.OnOpenPopup();
        return popup;
    }
    public void ClosePopup(PopupName popupName)
    {
        var popup = GetPopup(popupName);
        popup.gameObject.SetActive(false);
        popup.OnClosePopup();
    }

    public void CloseAllScreen()
    {
        foreach(var screen in screens)
        {
            screen.gameObject.SetActive(false);
            screen.OnCloseScreen();
        }
    }

    public void CloseAllPopup()
    {
        foreach (var popup in popups)
        {
            popup.gameObject.SetActive(false);
            popup.OnClosePopup();
        }
    }
}
