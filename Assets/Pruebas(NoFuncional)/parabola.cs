using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parabola : MonoBehaviour
{
    public int numPoints = 100;

    public LineRenderer lineRenderer;

    public float a = -1f;
    public float b = 0f;
    public float c = 0f;

    public float speedControl;
    float offX = 1;

    public Material mat;
    void Start()
    {
        lineRenderer.positionCount = 0;
    }

    private void Update()
    {
        CalculateAndDrawParabola();
        offsetEffect();
    }

    void offsetEffect()
    {
        offX -= 1 * Time.deltaTime * speedControl;
        if (offX < -1)
        {
            offX = 0;
        }
        mat.mainTextureOffset = new Vector2(offX, 1);
    }

    void CalculateAndDrawParabola()
    {
        lineRenderer.positionCount = numPoints;

        for (int i = 0; i < numPoints; i++)
        {
            float t = i / (float)(numPoints - 1); // Valor entre 0 y 1 para interpolar entre los puntos.
            float x = t * 10.0f; // Escala el valor de 't' para ajustar el rango de la parábola.
            float y = (a * x * x) + (b * x) + c; // Calcula 'y' en función de la ecuación cuadrática.

            //Asegura que la parábola se inicie desde el centro del objeto.
            Vector3 point = transform.position + new Vector3(x, y, 0);

            lineRenderer.SetPosition(i, point);
        }
    }
}
