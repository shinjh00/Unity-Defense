using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] EventSystem eventSystemPrefab;

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
}
