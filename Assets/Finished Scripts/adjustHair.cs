using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adjustHair : MonoBehaviour
{
    Vector3[] position = new Vector3[6];

    private void Start()
    {
        /*Las imagenes de pelos tienen tama�os diferentes,este script las ajusta en relaci�n a la posici�n del GameObject del personaje.
         Si se hace alg�n cambio, tener en cuenta que se refiere a posici�n local, no posici�n global.*/ 
        position[0] = new Vector3(0, 2.409f, 0);
        position[1] = new Vector3(-0.296f, 1.308f, 0);
        position[2] = new Vector3(-0.035f, 2.369f, 0);
        position[3] = new Vector3(-0.149f, 2.361f, 0);
        position[4] = new Vector3(0.06f, 2.163f, 0);       
        position[5] = new Vector3(0.04f, 2.292f, 0);
        Debug.Log("Posiciones creadas y guardadas");
    }
    public Vector3 adjustSize(int numHair)
    {
        return position[numHair];
    }
}
