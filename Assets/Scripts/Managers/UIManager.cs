using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] EventSystem eventSystemPrefab;

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
}
