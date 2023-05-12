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
        size = imgLoading.sizeDelta; //SetUILoading ������ ���� imgLoading�� ����(100%) ������ Ȯ��

        //�׽�Ʈ
        SetUILoading(0);
    }

    /// <summary> ������� �޾� �ε� UI ���� </summary>
    public void SetUILoading(float value)
    {
        size.x = value * size.x / 100;
        imgLoading.sizeDelta = size;
        txtLoading.text = $"{(int)value}%";
    }
}