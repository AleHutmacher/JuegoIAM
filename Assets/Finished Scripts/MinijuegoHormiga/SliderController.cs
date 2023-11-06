using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    [SerializeField] RamaBehaviour Objetive;

    Timer timer;

    Slider thisSlider;

    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find("Timer").GetComponent<Timer>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        thisSlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.getFinishedCountdown())
        {
            thisSlider.interactable = false;
            gameManager.moverHormiga();
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
