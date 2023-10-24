using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SubirRotacionZ : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject rama;
    bool buttonPressed = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (buttonPressed)
        {
            cambiarRotacionRama();
        }
    }

    void cambiarRotacionRama()
    {
        if (rama.transform.rotation.eulerAngles.z < 360 || rama.transform.rotation.eulerAngles.z == 0)
        {
            rama.transform.Rotate(new Vector3(0, 0, 0.25f), Space.World);
            Debug.Log(rama.transform.rotation.eulerAngles.z < 360);
            Debug.Log(rama.transform.rotation.eulerAngles.z - 360);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }
}
