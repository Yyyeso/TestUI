using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIInputPassword : MonoBehaviour
{
    [SerializeField] private Button btnHide;
    [SerializeField] private Image image;
    [SerializeField] private Sprite imgHide;
    [SerializeField] private Sprite imgShow;
    [SerializeField] private bool isHidden = true;

    private void OnValidate()
    {
        HideAction();
    }
    void Start()
    {
        isHidden = (image.sprite == imgHide) ? true : false;
        btnHide.onClick.AddListener(Hide);
    }

    void Hide()
    {
        isHidden = !isHidden;
        HideAction();
    }

    void HideAction()
    {
        image.sprite = (isHidden == true) ? imgHide : imgShow;
    }
}