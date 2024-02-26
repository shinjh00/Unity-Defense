using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WindowUI : BaseUI, IDragHandler, IPointerDownHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        // 포인터가 어디를 클릭했는지, 얼만큼 움직였는지 등은 매개변수인 eventData로 알 수 있음
        transform.Translate(eventData.delta);  // 변화량만큼 Translate 해줌
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Manager.UI.SelectWindowUI(this);  // 클릭했을 땐 화면에서 맨 위로
    }
}
