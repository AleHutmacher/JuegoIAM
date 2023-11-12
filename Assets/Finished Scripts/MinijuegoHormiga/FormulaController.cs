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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ordenada = Rama.position.y;
        UpdatePendiente();
        formula.text = $"y = {Pendiente} * x + {Rama.position.y}";
    }
    public void UpdatePendiente()
    {
        Pendiente = (Point2.position.y - Point1.position.y) / (Point2.position.x - Point1.position.x);
    }
}
