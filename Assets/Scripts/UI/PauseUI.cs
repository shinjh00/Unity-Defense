using UnityEngine;
using UnityEngine.UI;

public class PauseUI : PopUpUI
{
    [SerializeField] SettingUI settingUIPrefab;

    protected override void Awake()
    {
        base.Awake();

        GetUI<Button>("SettingButton").onClick.AddListener(Setting);
        // 이름이 "SettingButton"인 Button을 Click했을 때 Setting을 실행
        // onClick이 UnityEvent라서 AddListener를 써줘야됨

        GetUI<Button>("CloseButton").onClick.AddListener(Close);  // PopUpUI에 있는 Close()
    }

    public void Setting()
    {
        Manager.UI.ShowPopUpUI(settingUIPrefab);
    }
}
