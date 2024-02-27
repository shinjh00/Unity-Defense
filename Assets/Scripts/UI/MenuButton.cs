using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    [SerializeField] PauseUI pauseUIPrefab;
    [SerializeField] WindowUI windowUIPrefab;

    public void PauseClick()
    {
        Manager.UI.ShowPopUpUI(pauseUIPrefab);
    }

    public void WindowClick()
    {
        Manager.UI.ShowWindowUI(windowUIPrefab);
    }
}
