using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ToVR : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(SwitchToVR("cardboard"));
    }

    public IEnumerator SwitchToVR(string YESVR)
    {
        XRSettings.LoadDeviceByName(YESVR);
        yield return null;
        XRSettings.enabled = true;
    }
}
