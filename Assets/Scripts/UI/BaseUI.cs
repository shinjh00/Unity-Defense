using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BaseUI : MonoBehaviour
{
    protected Dictionary<string, Component> components;

    protected virtual void Awake()
    {
        Debug.Log("Binding");
        Bind();
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
        if (typeof(T) == typeof(TMP_Text))
        {
            return components[$"{name}_TextMeshProUGUI"] as T;
        }
        return components[$"{name}_{typeof(T).Name}"] as T;
    }
}
