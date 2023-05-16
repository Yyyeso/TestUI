using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIRoomInfo : MonoBehaviour
{
    [SerializeField] private Button btnDim;
    [SerializeField] private Button btnClose;
    [SerializeField] private GameObject info;
    [SerializeField] private TMP_Text txtInfo;

    void Start()
    {
        btnDim.onClick.AddListener(Close);
        btnClose.onClick.AddListener(Close);
    }

    void Close()
    {
        info.gameObject.SetActive(false);
    }

    public void Setup(RoomInfo info)
    {
        string strInfo;

        strInfo = $"* {info.title}\n* {info.about}";
        if (info.seletedDateOption)
        { strInfo += $"\n* ���: {info.date1}~{info.date2}"; }
        if (info.seletedLinkOption)
        { strInfo += $"\n* ��ũ: {info.link}"; }

        txtInfo.text = strInfo;
    }
}