using System.Collections.Generic;
using UnityEngine;

public class BaseUI : MonoBehaviour
{
    /* UI ���ε��� ���� ��ũ��Ʈ */

    protected Dictionary<string, Component> components;

    protected virtual void Awake()
    {
        Bind();
        // ���ε� �۾��� �ʱ� �ε����� ����Ǵٺ��� �� �ɷ��� ����
        // ���� �ΰ��ӿ��� Ž���� �ϸ� �Ǵ� ��Ÿ�� ���߿� �ɸ��� �ð��� ª��
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
