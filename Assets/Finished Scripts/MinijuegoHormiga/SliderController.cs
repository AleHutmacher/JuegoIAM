using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderController : MonoBehaviour
{
    [SerializeField] RamaBehaviour Objetive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateRamaRotation()
    {
        Objetive.UpdateRotation(GetComponent<UnityEngine.UI.Slider>().value);
    }
    public void UpdateRamaOrdenadaOrigen()
    {
        Objetive.UpdateOrdenadaOrigen(GetComponent<UnityEngine.UI.Slider>().value);
    }
}
