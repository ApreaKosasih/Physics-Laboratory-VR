using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GazeInteraction : MonoBehaviour
{
    public float gazeTime = 10f;
    private float timer;
    private bool gazeDat;
    
    
    void Update()
    {
        //
        if (gazeDat)
        {
            timer += Time.deltaTime;

            if (timer >= gazeTime)
            {
                ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
                timer = 0f;
            }
        }
    }

    public void PointerEnter()
    {
        gazeDat = true;
        Debug.Log("pointerEnter");
    }

    public void PointerExit()
    {
        gazeDat = false;
        Debug.Log("pointerExit");
    }

    public void PointerDown()
    {
        Debug.Log("Show");
    }

}
