using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UILoading : MonoBehaviour
{
    [SerializeField] private RectTransform imgLoading;
    [SerializeField] private TMP_Text txtLoading;
    private Vector2 size;

    private void Start()
    {
        imgLoading = GetComponentsInChildren<RectTransform>()[1];
        txtLoading = GetComponentInChildren<TMP_Text>();
        size = imgLoading.sizeDelta; //SetUILoading 실행을 위해 imgLoading의 원본(100%) 사이즈 확인

        //테스트
        SetUILoading(0);
    }

    /// <summary> 진행률을 받아 로딩 UI 셋팅 </summary>
    public void SetUILoading(float value)
    {
        size.x = value * size.x / 100;
        imgLoading.sizeDelta = size;
        txtLoading.text = $"{(int)value}%";
    }
}