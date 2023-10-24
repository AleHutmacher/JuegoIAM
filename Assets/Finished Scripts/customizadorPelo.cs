using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customizadorPelo : customizador
{
    public GameObject bodyPartObj;

    adjustHair adjust;
    private void Start()
    {
        adjust = GetComponent<adjustHair>();
    }

    public override void changeOption()
    {
        base.changeOption();
        cambiarPelo(currentOption);
    }

    public void cambiarPelo(int num)
    {
        bodyPart.sprite = options[num];
        bodyPartObj.transform.localPosition = adjust.adjustSize(num);
    }
}
