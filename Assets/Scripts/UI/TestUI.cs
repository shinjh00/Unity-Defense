using TMPro;
using UnityEngine.UI;

public class TestUI : BaseUI
{
    // BaseUI, BaseUI_T를 사용할 때의 예시

    protected override void Awake()
    {
        base.Awake();

        /* BaseUI_T 상속 */
        GetUI<TMP_Text>("Title").text = "Title";
        GetUI<Button>("NextButton").interactable = false;
    }
}
