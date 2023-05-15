using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIPopUp : MonoBehaviour
{
    [SerializeField] protected TMP_Text txtMessage;
    [SerializeField] protected string message;

    void OnValidate()
    {
        message = message.Replace("\\n", "\n");
        txtMessage.text = message;
    }

    void Start()
    {

    }
}