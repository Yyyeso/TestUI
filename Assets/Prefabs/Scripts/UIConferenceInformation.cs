using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIConferenceInformation : MonoBehaviour
{
    [SerializeField] private Button btnDim;
    [SerializeField] private Button btnClose;
    [SerializeField] private GameObject information;
    [SerializeField] private TMP_Text txtInformation;

    void Start()
    {
        btnDim.onClick.AddListener(Close);
        btnClose.onClick.AddListener(Close);
    }

    void Close()
    {
        information.gameObject.SetActive(false);
    }

    public void Setup(ConferenceInformation infor)
    {
        string strInfor;

        strInfor = $"* {infor.title}\n* {infor.about}";
        if (infor.seletedDateOption)
        { strInfor += $"\n* 행사: {infor.date1}~{infor.date2}"; }
        if (infor.seletedLinkOption)
        { strInfor += $"\n* 링크: {infor.link}"; }

        txtInformation.text = strInfor;
    }
}