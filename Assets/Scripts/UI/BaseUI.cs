using System.Collections.Generic;
using UnityEngine;

public class BaseUI : MonoBehaviour
{
    /* UI 바인딩을 위한 스크립트 */

    protected Dictionary<string, Component> components;

    protected virtual void Awake()
    {
        Bind();
        // 바인딩 작업이 초기 로딩에서 실행되다보니 좀 걸려도 무관
        // 이후 인게임에서 탐색만 하면 되니 런타임 도중에 걸리는 시간은 짧음
    }

    private void Bind()
    {
        components = new Dictionary<string, Component>();
        Component[] children = GetComponentsInChildren<Component>();
        foreach (Component child in children)
        {
            string name = $"{child.gameObject.name}_{child.GetType().Name}";
            components.Add(name, child);
        }
    }

    public T GetUI<T>(string name) where T : Component
    {
        return components[$"{name}_{typeof(T).Name}"] as T;
    }
}
