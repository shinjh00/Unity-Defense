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
        // Ŭ������ ��
        Debug.Log("Click");
    }

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

    public void OnPointerUp(PointerEventData eventData)
    {
        // ���콺�� ����� ��
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
