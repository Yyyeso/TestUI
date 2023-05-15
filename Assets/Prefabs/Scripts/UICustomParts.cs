using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum ShapeType
{
    Circle,
    Square
}

public class UICustomParts : MonoBehaviour
{
    [SerializeField] private ShapeType type;
    [SerializeField] private Button btnOption;
    [SerializeField] private Image imgOption;
    [SerializeField] private Image imgMask;
    [SerializeField] private Image Outline;

    Color defaultColor;
    Color selectedColor;
    float defaultPPU = 2;
    float selectedtPPU = 1.4f;
    bool test = false;


    void Start()
    {
        btnOption.onClick.AddListener(Test);
        ColorUtility.TryParseHtmlString("#A4A4A4", out defaultColor);
        ColorUtility.TryParseHtmlString("#FFC000", out selectedColor);
        defaultPPU = (type == ShapeType.Circle) ? 1 : 2;
        selectedtPPU = (type == ShapeType.Circle) ? 2.3f : 1.4f;
    }

    public void Setup(Sprite sprite)
    {
        imgOption.sprite = sprite; 
    }

    void Test()
    {
        test = !test;
        if (test)
        { Select(); }
        else
        { Clear(); }
    }

    void Select()
    {
        imgMask.pixelsPerUnitMultiplier = selectedtPPU;
        Outline.pixelsPerUnitMultiplier = selectedtPPU;
        Outline.color = selectedColor;
    }

    void Clear()
    {
        imgMask.pixelsPerUnitMultiplier = defaultPPU;
        Outline.pixelsPerUnitMultiplier = defaultPPU;
        Outline.color = defaultColor;
    }
}