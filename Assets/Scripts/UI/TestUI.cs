using TMPro;
using UnityEngine.UI;

public class TestUI : BaseUI
{
    // BaseUI, BaseUI_T�� ����� ���� ����

    protected override void Awake()
    {
        base.Awake();

        /* BaseUI_T ��� */
        GetUI<TMP_Text>("Title").text = "Title";
        GetUI<Button>("NextButton").interactable = false;
    }
}
