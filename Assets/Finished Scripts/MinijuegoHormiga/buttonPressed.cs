using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class buttonPressed : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool isPressed;

    private void Start()
    {
        isPressed = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }

    public bool getIsPressed()
    {
        return isPressed;
    }
}
