using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class menuPrincipal : MonoBehaviour
{
    //Timelines del menú del customizador.
    public PlayableDirector customizadorOn;
    public PlayableDirector customizadorOff;

    //Timelines del menú de juego.
    public PlayableDirector playOn;
    public PlayableDirector playOff;

    //EventSystem para poder desactivarlo e impedir interacciones en medio de una animación.
    public GameObject eventSystem;
    public void cerrarJuego()
    {
        Application.Quit();
    }

    public void disableEvents()
    {
        StartCoroutine("disableEventSystem2Seconds");
    }

    IEnumerator disableEventSystem2Seconds()
    {
        eventSystem.SetActive(false);
        yield return new WaitForSeconds(2);
        eventSystem.SetActive(true);
    }

    public void customOn()
    {
        customizadorOn.Play();
    }

    public void customOff()
    {
        customizadorOff.Play();
    }

    public void playMenuOn()
    {
        playOn.Play();
    }

    public void playMenuOff()
    {
        playOff.Play();
    }
}
