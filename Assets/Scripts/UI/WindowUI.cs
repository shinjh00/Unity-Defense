using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WindowUI : BaseUI, IDragHandler, IPointerDownHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        // �����Ͱ� ��� Ŭ���ߴ���, ��ŭ ���������� ���� �Ű������� eventData�� �� �� ����
        transform.Translate(eventData.delta);  // ��ȭ����ŭ Translate ����
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Manager.UI.SelectWindowUI(this);  // Ŭ������ �� ȭ�鿡�� �� ����
    }
}
