using UnityEngine;
using UnityEngine.UI;

public class PauseUI : PopUpUI
{
    [SerializeField] SettingUI settingUIPrefab;

    protected override void Awake()
    {
        base.Awake();

        GetUI<Button>("SettingButton").onClick.AddListener(Setting);
        // �̸��� "SettingButton"�� Button�� Click���� �� Setting�� ����
        // onClick�� UnityEvent�� AddListener�� ����ߵ�

        GetUI<Button>("CloseButton").onClick.AddListener(Close);  // PopUpUI�� �ִ� Close()
    }

    public void Setting()
    {
        Manager.UI.ShowPopUpUI(settingUIPrefab);
    }
}
