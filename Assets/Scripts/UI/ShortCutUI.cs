using UnityEngine.UI;

public class ShortCutUI : PopUpUI
{
    protected override void Awake()
    {
        base.Awake();

        GetUI<Button>("CloseButton").onClick.AddListener(Close);
    }
}
