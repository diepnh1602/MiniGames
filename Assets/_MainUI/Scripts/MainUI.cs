using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUI : UIBase
{
    public override void OnOpenUI()
    {
        base.OnOpenUI();
        ShowScreen(ScreenName.Menu);
    }
}
