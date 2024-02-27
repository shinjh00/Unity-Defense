using UnityEngine;
using UnityEngine.EventSystems;

public class TowerPlace : MonoBehaviour
    , IPointerEnterHandler
    , IPointerExitHandler
    , IPointerDownHandler
    , IPointerUpHandler
    , IPointerClickHandler
    , IPointerMoveHandler
{
    [SerializeField] Renderer render;
    [SerializeField] Color normalColor;
    [SerializeField] Color highlightColor;

    [SerializeField] InGameUI buildUI;

    public void OnPointerEnter(PointerEventData eventData)
    {
        // �����Ͱ� ������Ʈ�� �ö��� ��
        render.material.color = highlightColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // �����Ͱ� ������Ʈ�� ����� ��
        render.material.color = normalColor;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // �����Ͱ� ������Ʈ ������ ������ ��
        Debug.Log("Down");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // �����͸� �� ��
        Debug.Log("Up");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // ������Ʈ���� �����͸� ������ �� ��
        InGameUI ui = Manager.UI.ShowInGameUI(buildUI);
        ui.SetTarget(transform);
        ui.SetOffset(new Vector3(0, 150, 0));
    }

    public void OnPointerMove(PointerEventData eventData)
    {
        // ������Ʈ ������ ������ ��
        Debug.Log("Move");
    }
}
