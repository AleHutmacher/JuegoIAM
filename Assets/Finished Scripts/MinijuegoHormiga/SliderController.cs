using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    [SerializeField] RamaBehaviour Objetive;

    [SerializeField] Timer timer;

    [SerializeField] Slider thisSlider;

    //[SerializeField] GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer.getFinishedCountdown())
        {
            thisSlider.interactable = false;
            //gameManager.moverHormiga();
        }
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
