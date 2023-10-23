using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBase : MonoBehaviour
{
    public ScreenName ScreenName;

    public virtual void OnOpenScreen() { }

    public virtual void OnCloseScreen() { }
}
