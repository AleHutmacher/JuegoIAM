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
        TMP.text = "(0, 0)";
    }


    void Update()
    {

        Vector3 coordenadas = target.position;
        TMP.text = "(" + System.Math.Round(coordenadas.x, 2) + 
                  "; " + System.Math.Round(coordenadas.y, 2) + ")";

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
