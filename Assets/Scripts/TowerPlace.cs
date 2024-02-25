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

    public void OnPointerEnter(PointerEventData eventData)
    {
        // �����Ͱ� ������Ʈ�� �ö��� ��
        render.material.color = highlightColor;
        Debug.Log("Enter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // �����Ͱ� ������Ʈ�� ����� ��
        render.material.color = normalColor;
        Debug.Log("Exit");
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
        Debug.Log("Click");
    }

    public void OnPointerMove(PointerEventData eventData)
    {
        // ������Ʈ ������ ������ ��
        Debug.Log("Move");
    }
}
