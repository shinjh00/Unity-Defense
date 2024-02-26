using UnityEngine;

public class PauseButton : MonoBehaviour
{
    [SerializeField] PauseUI pauseUIPrefab;

    public void Click()
    {
        Manager.UI.ShowPopUpUI(pauseUIPrefab);
    }
}
