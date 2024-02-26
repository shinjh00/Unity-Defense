using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] EventSystem eventSystemPrefab;

    [Header("PopUp")]
    [SerializeField] Canvas popUpCanvas;
    [SerializeField] Image popUpBlocker;

    [Header("Window")]
    [SerializeField] Canvas windowCanvas;

    private Stack<PopUpUI> popUpStack = new Stack<PopUpUI>();

    private void Awake()
    {
        // 초기에 EventSystem 확인 작업 먼저 수행
        EnsureEventSystem();
    }

    public void EnsureEventSystem()
    {
        // 만약 EventSystem이 없을 시 넣어주기 위해

        EventSystem eventSystem = FindObjectOfType<EventSystem>();  // EventSystem을 찾아보고
        if (eventSystem == null)  // 없으면
        {
            Instantiate(eventSystemPrefab);  // 프리팹으로 새로 생성
        }
    }

    public T ShowPopUpUI<T>(T popUpUI) where T : PopUpUI  // PopUpUI를 반환해야 함
    {
        if (popUpStack.Count > 0)  // 이미 팝업이 열려있다면
        {
            PopUpUI prevUI = popUpStack.Peek();  // 맨 위에 있는 팝업을 가져와서
            prevUI.gameObject.SetActive(false);  // 비활성화 시키기
        }

        T instance = Instantiate(popUpUI, popUpCanvas.transform);  // popUpUI는 프리팹이어야하니까 인스턴스를 만들어야 됨 (Canvas안에 자식으로)
        popUpStack.Push(instance);  // 마지막에 연 팝업이 가장 위에 있어야 하므로 Stack 구조로
        Time.timeScale = 0f;  // 팝업을 띄웠을 땐 시간을 멈추게 하고
        popUpBlocker.gameObject.SetActive(true);  // Blocker 활성화

        return instance;
    }

    public void ClosePopUpUI()  // PopUpUI를 닫기만 하면 됨 (void)
    {
        PopUpUI curUI = popUpStack.Pop();
        Destroy(curUI.gameObject);  // 가장 위에 있는 팝업을 가져와서 삭제하기

        if (popUpStack.Count > 0)  // 닫았는데도 팝업이 남아있으면
        {
            PopUpUI prevUI = popUpStack.Peek();  // 남은 팝업 중에 가장 위에 있는 것을 가져와서
            prevUI.gameObject.SetActive(true);  // 활성화 시키기
        }
        else  // 남은 팝업이 없으면
        {
            Time.timeScale = 1f;  // 시간이 다시 흐르게 하고
            popUpBlocker.gameObject.SetActive(false);  // Blocker 비활성화
        }
    }

    public T ShowWindowUI<T>(T windowUI) where T : WindowUI
    {
        T ui = Instantiate(windowUI, windowCanvas.transform);
        return ui;
    }

    public void CloseWindowUI<T>(T windowUI) where T : WindowUI
    {
        Destroy(windowUI.gameObject);
    }

    public void SelectWindowUI(WindowUI windowUI)
    {
        // 선택한 windowUI를 계층구조 가장 뒤쪽으로 (화면에선 가장 앞으로) 밀어주기
        windowUI.transform.SetAsLastSibling();  // sibling : 형제
    }
}
