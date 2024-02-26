public class PopUpUI : BaseUI
{
    public void Close()
    {
        // Close는 어디서도 쓰이니까 ~UI들의 부모인 PopUpUI에 구현
        Manager.UI.ClosePopUpUI();
    }
}
