using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class HistoriaManager : MonoBehaviour
{
    private Image panel;
    public float duracionAnimacion;
    private Color colorInicial;
    private Color colorFinal;
    private float tiempoPasado = 0f;
    private bool animacionIniciada = false;

    private void Start()
    {
    }

    private void Update()
    {
        if (animacionIniciada)
        {
            tiempoPasado += Time.deltaTime;

            if (tiempoPasado <= duracionAnimacion)
            {
                float factor = tiempoPasado / duracionAnimacion;
                panel.color = Color.Lerp(colorInicial, colorFinal, factor);

                Image[] imagenesHijas = panel.GetComponentsInChildren<Image>();
                foreach (Image imagenHija in imagenesHijas)
                {
                    imagenHija.color = new Color(panel.color.r, panel.color.g, panel.color.b, panel.color.a);
                }

                TextMeshProUGUI[] textosHijosTMP = panel.GetComponentsInChildren<TextMeshProUGUI>();
                foreach (TextMeshProUGUI textoHijoTMP in textosHijosTMP)
                {
                    textoHijoTMP.color = new Color(panel.color.r, panel.color.g, panel.color.b, panel.color.a);
                }


            }
            else
            {
                animacionIniciada = false;
                Destroy(panel.gameObject);
            }
        }
    }

    public void AnimarPanel(Image panel)
    {
        this.panel = panel;
        colorInicial = panel.color;
        colorFinal = new Color(colorInicial.r, colorInicial.g, colorInicial.b, 0f);
        tiempoPasado = 0f;
        animacionIniciada = true;
    }


    public void PasarALaEscena(string nombreScena)
    {
        SceneManager.LoadScene(nombreScena);
    }

    public void DesactivarBoton(Button boton)
    {
        boton.interactable = false;
        Destroy(boton.gameObject);
    }

    public void ActivarBoton(Button boton)
    {
        boton.interactable = true;
    }


}

