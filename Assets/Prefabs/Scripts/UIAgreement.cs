using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

enum AgreementType
{
    Mandatory,
    Optional
}

public class UIAgreement : UIRadioButton
{
    [SerializeField] private AgreementType type;
    [SerializeField] private TMP_Text txtType;
    string[] strType = new string[] { "필수", "선택" };
    Color[] colorType = new Color[] { Color.red, Color.blue };

    private void OnValidate()
    {
        Modifiable();
        SetType();
    }
    void Start()
    {
        Setup();
        SetType();
    }

    void SetType()
    {
        txtType.text = $"({strType[(int)type]})";
        txtType.color = colorType[(int)type];
    }
}