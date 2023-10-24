using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ModificarMovimientoX : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject rama;

    public float movementSpeed;

    bool buttonPressed;

    public int indicador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonPressed)
        {
            modificarMovimiento();
        }
    }

    void aumentarEjeX()
    {
            rama.transform.Translate(movementSpeed * Time.deltaTime, 0, 0, Space.Self);
    }

    void disminuirEjeX()
    {
            rama.transform.Translate(-movementSpeed * Time.deltaTime, 0, 0, Space.Self);
    }

    void modificarMovimiento()
    {
        /*if (rama.transform.position.y > -1 && rama.transform.position.y < 2 && rama.transform.position.x > 1  && rama.transform.position.x < 5)
        {
            
        }*/
        if (indicador == 1)
        {
            aumentarEjeX();
        }
        else
        {
            disminuirEjeX();
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
