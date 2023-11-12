using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class customizador : MonoBehaviour
{
    public SpriteRenderer bodyPart;

    public List<Sprite> options = new List<Sprite>();

    public int currentOption = 0;

    public string prefName;

    public virtual void nextOption()
    {
        currentOption++;
        if (currentOption >= options.Count)
        {
            currentOption = 0;
        }
        changeOption();
    }

    public virtual void previousOption()
    {
        currentOption--;
        if (currentOption < 0)
        {
            currentOption = options.Count - 1;
        }
        changeOption();
    }

    public virtual void changeOption()
    {
        bodyPart.sprite = options[currentOption];
        PlayerPrefs.SetInt(prefName, currentOption);
    }

    public void loadOptionSaved(int option)
    {
        currentOption = option;
        changeOption();
    }
}