using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FormulaController : MonoBehaviour
{
    [SerializeField] Transform Point1, Point2;
    [SerializeField] Transform Rama;
    [SerializeField] TextMeshProUGUI formula;
    private float Pendiente, Ordenada;
    [SerializeField]private float truncPendiente, truncOrdenada;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        updateOrdenada();
        UpdatePendiente();
        formula.text = $"y = {truncPendiente} * x + {truncOrdenada}";
    }
    public void UpdatePendiente()
    {
        Pendiente = (Point2.position.y - Point1.position.y) / (Point2.position.x - Point1.position.x);
        truncPendiente = Mathf.Floor(Pendiente * 100) / 100;
    }

    public void updateOrdenada()
    {
        Ordenada = Rama.position.y;
        truncOrdenada = Mathf.Floor(Ordenada * 100) / 100;

    }
}
