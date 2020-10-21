using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ToNormal : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(SwitchTo2D("none"));
    }

    public IEnumerator SwitchTo2D(string NOVR)
    {
        XRSettings.LoadDeviceByName(NOVR);
        yield return null;
        XRSettings.enabled = false;
    }
}
