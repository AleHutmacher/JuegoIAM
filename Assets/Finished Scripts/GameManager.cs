using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool nivelFinalizado = false;

    private PlayerManager playerManager;

    private void Start()
    {
        playerManager = GameObject.Find("PlayerManager").GetComponent<PlayerManager>();
        playerManager.getAllCustomizers();
        playerManager.getAllPlayerPrefs();
        playerManager.initializeCustomizers();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moverHormiga()
    {
        if (!nivelFinalizado)
        {
            Debug.Log("Moviendo hormiga...");
            //codigo de empezar animacion || empezar movimiento || aplicar fuerza.
            nivelFinalizado = true; //Esta linea hace que el codigo no se repita infinitamente, sino que solo sea llamado una vez. Quitar o mantener segun el metodo usado para mover la hormiga.
        }      
    }

    public void irAEscena(string escena)
    {
        SceneManager.LoadScene(escena);
    }
}
