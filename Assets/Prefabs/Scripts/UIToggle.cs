using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIToggle : MonoBehaviour
{
    [SerializeField] protected Button btnToggle;
    [SerializeField] protected GameObject selectedToggle;
    [SerializeField] protected TMP_Text txtLanguage;
    [SerializeField] protected string language;
    [SerializeField] protected bool isSelected;

    void OnValidate()
    {
        Modifiable();
    }

    void Start()
    {
        Setup();
    }

    protected void Setup()
    {
        isSelected = selectedToggle.activeSelf;
        btnToggle.onClick.AddListener(Select);
    }
    protected void Modifiable()
    {
        txtLanguage.text = language;
        selectedToggle.SetActive(isSelected);
    }

    protected void Select()
    {
        isSelected = !isSelected;
        selectedToggle.SetActive(isSelected);
    }
}