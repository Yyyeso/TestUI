using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum UISizeType
{
    Width,
    Height,
    Both
}

public class UISetSize : MonoBehaviour
{
    [SerializeField] private RectTransform parent;
    [SerializeField] private RectTransform revise;
    [SerializeField] private RectTransform tr;
    [SerializeField] private UISizeType type;

    void OnValidate()
    {
        print(parent.sizeDelta);
        SetSize();
    }

    void Start()
    {
        SetSize();
    }

    void SetSize()
    {
        switch (type)
        {
            case UISizeType.Width:
                float width = parent.sizeDelta.x + revise.sizeDelta.x;
                tr.sizeDelta = new Vector2(width, tr.sizeDelta.y);
                break;
            case UISizeType.Height:
                float height = parent.sizeDelta.y + revise.sizeDelta.y;
                tr.sizeDelta = new Vector2(tr.sizeDelta.x, height);
                break;
            case UISizeType.Both:
                tr.sizeDelta = parent.sizeDelta;
                break;
        }
    }
}