using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConferenceInformation
{
    public string title;
    public string about;
    public string date1;
    public string date2;
    public string link;
    public bool seletedDateOption;
    public bool seletedLinkOption;

    public ConferenceInformation(string title, string about, string date1, string date2, string link, bool dateOption, bool linkOption)
    {
        this.title = title;
        this.about = about;
        this.date1 = date1;
        this.date2 = date2;
        this.link = link;
        seletedDateOption = dateOption;
        seletedLinkOption = linkOption;
    }
}