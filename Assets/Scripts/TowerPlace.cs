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
        // 포인터가 오브젝트에 올라갔을 때
        render.material.color = highlightColor;
        Debug.Log("Enter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // 포인터가 오브젝트를 벗어났을 때
        render.material.color = normalColor;
        Debug.Log("Exit");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // 포인터가 오브젝트 위에서 눌렸을 때
        Debug.Log("Down");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // 포인터를 뗄 때
        Debug.Log("Up");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // 오브젝트에서 포인터를 누르고 뗄 때
        Debug.Log("Click");
    }

    public void OnPointerMove(PointerEventData eventData)
    {
        // 오브젝트 위에서 움직일 때
        Debug.Log("Move");
    }
}
