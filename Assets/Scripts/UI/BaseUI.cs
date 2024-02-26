using System.Collections.Generic;
using TMPro;
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

    public void Bind()
    {
        components = new Dictionary<string, Component>();
        Component[] children = GetComponentsInChildren<Component>();

        foreach (Component child in children)
        {
            string name = $"{child.gameObject.name}_{child.GetType().Name}";
            if (components.ContainsKey(name))  // �̸� �ߺ��̸�
                continue;                      // �����ϰ� ����

            components.Add(name, child);
        }
    }

    public T GetUI<T>(string name) where T : Component
    {
        if (typeof(T) == typeof(TMP_Text))  // TMP_Text ����ϱ� ����
        {
            return components[$"{name}_TextMeshProUGUI"] as T;
        }

        return components[$"{name}_{typeof(T).Name}"] as T;
    }
}
