using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausarManager : MonoBehaviour
{
    public GameObject cuadroPausa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PausarBoton()
    {
        cuadroPausa.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ContinuarBoton()
    {
        cuadroPausa.SetActive(false);
        Time.timeScale = 1f;
    }
}
