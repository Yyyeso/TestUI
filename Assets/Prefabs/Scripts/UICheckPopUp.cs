using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UICheckPopUp : UIPopUp
{
    [SerializeField] protected TMP_Text txtTitle;
    [SerializeField] protected string title;

    void OnValidate()
    {
        txtTitle.text = title;
        txtMessage.text = message;
    }
}