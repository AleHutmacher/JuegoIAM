using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour
{
    [SerializeField]int contactos = 0;
    // Start is called before the first frame update
    void Start()
    {
        contactos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void aumentarContactos()
    {
        contactos++;
    }
}
