using UnityEngine;
using UnityEngine.UI;

public class SettingUI : PopUpUI
{
    [SerializeField] ShortCutUI shortCutUIPrefab;

    protected override void Awake()
    {
        base.Awake();

        GetUI<Button>("ShortCutButton").onClick.AddListener(ShortCut);
        GetUI<Button>("CloseButton").onClick.AddListener(Close);
    }

    public void ShortCut()
    {
        Manager.UI.ShowPopUpUI(shortCutUIPrefab);
    }
}
