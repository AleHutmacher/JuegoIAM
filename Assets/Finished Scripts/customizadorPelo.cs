using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customizadorPelo : customizador
{
    public GameObject bodyPartObj;

    Vector3[] position = new Vector3[6];
    private void Start()
    {
        //initializeHairPositions();
    }

    public override void changeOption()
    {
        base.changeOption();
        adjustHairPosition();
    }

    void adjustHairPosition()
    {
        /*Se inicializan acá las posiciones debido a un bug provocado por la carga de opciones del PlayerPrefs en PlayerManager.
        El bug aparentemente consiste en que aunque se mande a inicializar las posiciones en el start de este código,
        este start se ejecuta luego de lo anterior, ya que todo lo anterior lo llama el start del PlayerManager.
        No cambiar si no se encontró solución para esto. */
        initializeHairPositions();
        Vector3 posNueva = adjustSize(currentOption);
        Debug.Log($"Ajustando pos...; Opcion: {currentOption}, a Pos: {posNueva}");
        bodyPartObj.transform.localPosition = posNueva;
    }

    void initializeHairPositions()
    {
        /*Las imagenes de pelos tienen tamaños diferentes,este script las ajusta en relación a la posición del GameObject del personaje.
         Si se hace algún cambio, tener en cuenta que se refiere a posición local, no posición global.*/
        position[0] = new Vector3(0, 2.409f, 0);
        position[1] = new Vector3(-0.296f, 1.308f, 0);
        position[2] = new Vector3(-0.035f, 2.369f, 0);
        position[3] = new Vector3(-0.149f, 2.361f, 0);
        position[4] = new Vector3(0.06f, 2.163f, 0);
        position[5] = new Vector3(0.04f, 2.292f, 0);
    }

    public Vector3 adjustSize(int numHair)
    {
        return position[numHair];
    }
}
