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
        // �ʱ⿡ EventSystem Ȯ�� �۾� ���� ����
        EnsureEventSystem();
    }

    public void EnsureEventSystem()
    {
        // ���� EventSystem�� ���� �� �־��ֱ� ����

        EventSystem eventSystem = FindObjectOfType<EventSystem>();  // EventSystem�� ã�ƺ���
        if (eventSystem == null)  // ������
        {
            Instantiate(eventSystemPrefab);  // ���������� ���� ����
        }
    }

    public T ShowPopUpUI<T>(T popUpUI) where T : PopUpUI  // PopUpUI�� ��ȯ�ؾ� ��
    {
        if (popUpStack.Count > 0)  // �̹� �˾��� �����ִٸ�
        {
            PopUpUI prevUI = popUpStack.Peek();  // �� ���� �ִ� �˾��� �����ͼ�
            prevUI.gameObject.SetActive(false);  // ��Ȱ��ȭ ��Ű��
        }

        T instance = Instantiate(popUpUI, popUpCanvas.transform);  // popUpUI�� �������̾���ϴϱ� �ν��Ͻ��� ������ �� (Canvas�ȿ� �ڽ�����)
        popUpStack.Push(instance);  // �������� �� �˾��� ���� ���� �־�� �ϹǷ� Stack ������
        Time.timeScale = 0f;  // �˾��� ����� �� �ð��� ���߰� �ϰ�
        popUpBlocker.gameObject.SetActive(true);  // Blocker Ȱ��ȭ

        return instance;
    }

    public void ClosePopUpUI()  // PopUpUI�� �ݱ⸸ �ϸ� �� (void)
    {
        PopUpUI curUI = popUpStack.Pop();
        Destroy(curUI.gameObject);  // ���� ���� �ִ� �˾��� �����ͼ� �����ϱ�

        if (popUpStack.Count > 0)  // �ݾҴµ��� �˾��� ����������
        {
            PopUpUI prevUI = popUpStack.Peek();  // ���� �˾� �߿� ���� ���� �ִ� ���� �����ͼ�
            prevUI.gameObject.SetActive(true);  // Ȱ��ȭ ��Ű��
        }
        else  // ���� �˾��� ������
        {
            Time.timeScale = 1f;  // �ð��� �ٽ� �帣�� �ϰ�
            popUpBlocker.gameObject.SetActive(false);  // Blocker ��Ȱ��ȭ
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
        // ������ windowUI�� �������� ���� �������� (ȭ�鿡�� ���� ������) �о��ֱ�
        windowUI.transform.SetAsLastSibling();  // sibling : ����
    }
}
