using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupBase : MonoBehaviour
{
    public PopupName PopupName;

    public virtual void OnOpenPopup() { }

    public virtual void OnClosePopup() { }
}
