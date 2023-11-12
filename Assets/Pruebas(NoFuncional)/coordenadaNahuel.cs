using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.Jobs;
using Unity.Mathematics;

public class coordenadasDeRama : MonoBehaviour
{
    public Transform target;
    public TextMeshProUGUI TMP;

    void Start()
    {
        TMP.text = "X = 0  Y = 0";
    }


    void Update()
    {

        Vector3 coordenadas = target.position;
        TMP.text = "X = " + System.Math.Round(coordenadas.x, 3) + 
                  "\n" + "Y = " + System.Math.Round(coordenadas.y, 3);

    }

    private ArrayList getCoordasExtremos()
    {
        ArrayList coordenadasList = new ArrayList();

        Transform parent = target.parent.transform;

        foreach (Transform son in parent)
        {
            coordenadasList.Add(son.position);
        }

        return coordenadasList;
    }
}
