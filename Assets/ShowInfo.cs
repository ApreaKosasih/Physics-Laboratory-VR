using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInfo : MonoBehaviour
{
    public GameObject InfoObject;
    private bool Show = false;

    public void ShowHideInfo()
    {
        if (!Show)
        {
            InfoObject.SetActive(true);
            Show = true;
        }
        else
        {
            InfoObject.SetActive(false);
            Show = false;
        }
    }
}