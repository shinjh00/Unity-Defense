using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class TowerPlace : MonoBehaviour
    , IPointerClickHandler
    , IPointerEnterHandler
    , IPointerExitHandler
    , IPointerUpHandler
    , IPointerDownHandler
    , IPointerMoveHandler
{
    [SerializeField] Renderer render;
    [SerializeField] Color normalColor;
    [SerializeField] Color highlightColor;

    public void OnPointerClick(PointerEventData eventData)
    {
        // 클릭했을 때
        Debug.Log("Click");
    }

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

    public void OnPointerUp(PointerEventData eventData)
    {
        // 마우스를 들었을 때
        Debug.Log("Up");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // 
        Debug.Log("Down");
    }

    public void OnPointerMove(PointerEventData eventData)
    {
        // 
        Debug.Log("Move");
    }
}
