using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    private int hairOption = 0;
    private int glassesOption = 0;
    private int barbaOption = 0;
    private int clothOption = 0;

    private customizador customPelo, customLentes, customBarba, customRopa;

    public void getAllCustomizers()
    {
        customPelo = GameObject.Find("SelectorPelo").GetComponent<customizador>();
        customLentes = GameObject.Find("SelectorLentes").GetComponent<customizador>();
        customBarba = GameObject.Find("SelectorBarba").GetComponent<customizador>();
        customRopa = GameObject.Find("SelectorRopa").GetComponent<customizador>();
    }

    public void getAllPlayerPrefs()
    {
        hairOption = PlayerPrefs.GetInt("hairPref", 0);
        glassesOption = PlayerPrefs.GetInt("glassesPref", 0);
        barbaOption = PlayerPrefs.GetInt("barbaPref", 0);
        clothOption = PlayerPrefs.GetInt("clothPref", 0);
    }

    public void initializeCustomizers()
    {
        if (customPelo != null && customLentes != null && customBarba != null && customRopa != null)
        {
            customLentes.loadOptionSaved(glassesOption);
            customBarba.loadOptionSaved(barbaOption);
            customPelo.loadOptionSaved(hairOption);
            customRopa.loadOptionSaved(clothOption);
        }        
    }
}
