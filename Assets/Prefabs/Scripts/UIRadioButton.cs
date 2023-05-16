using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIRadioButton : MonoBehaviour
{
    [SerializeField] protected Button btnRadio;
    [SerializeField] protected GameObject selectedRadio;
    [SerializeField] protected TMP_Text txtName;
    [SerializeField] protected string buttonName;
    [SerializeField] protected bool isSelected;

    void OnValidate()
    {
        Modifiable();
    }

    void Start()
    {
        if (btnRadio == null)
        { btnRadio = GetComponent<Button>(); }

        Setup();
    }

    protected void Setup()
    {
        isSelected = selectedRadio.activeSelf;
        btnRadio.onClick.AddListener(Select);
    }
    protected void Modifiable()
    {
        txtName.text = buttonName;
        selectedRadio.SetActive(isSelected);
    }

    protected void Select()
    {
        isSelected = !isSelected;
        selectedRadio.SetActive(isSelected);
    }
}