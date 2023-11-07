using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HormigaBehaviour : MonoBehaviour
{
    [SerializeField] Transform BordeAcantiladoInf;
    [SerializeField] bool llegoAlBordeInf = false;
    [SerializeField] Transform BordeAcantiladoSup;
    [SerializeField] bool llegoAlBordeSup = false;
    [SerializeField] Transform Destiny;
    [SerializeField] bool CanMove = false;
    [SerializeField] Transform RamaTransform;
    private bool saltoInf = false;
    private bool saltoSup = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CanMove)
        {
            MoveToBorderInf();
            MoveToBorderSup();
            MoveToDestiny();
        }
        if (llegoAlBordeSup)
        {
            saltoInf = true;
        }
    }

    private void MoveToBorderSup()
    {
        if (llegoAlBordeInf && !llegoAlBordeSup && PuedeSubirLaPendiente())
        {
            if (!saltoInf) SaltarHaciaAdelante();
            transform.position = Vector3.MoveTowards(transform.position, BordeAcantiladoSup.position, 1.5f * Time.deltaTime);
        }
    }

    private void SaltarHaciaAdelante()
    {
        // salta hacia adelante con elevacion de 1 y distancia de 1
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x + 1, transform.position.y + 1, transform.position.z), 1.5f * Time.deltaTime);
    }

    private bool PuedeSubirLaPendiente()
    {
        //Debug.Log($"Rotacion: {RamaTransform.rotation.z}");
        //Debug.Log($"Posicion y: {RamaTransform.position.y}");
        bool retorno = (RamaTransform.rotation.z >= 0.20f && RamaTransform.rotation.z <= 0.25f) && (RamaTransform.position.y >= 1f && RamaTransform.position.y <= 1.2f);
        if (retorno)
        {
            //Debug.Log("Puede subir la pendiente");
            RamaTransform.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;

        }
        return retorno;
    }

    private void MoveToBorderInf()
    {
        if (!llegoAlBordeInf)
        {
            transform.position = Vector3.MoveTowards(transform.position, BordeAcantiladoInf.position, 2f * Time.deltaTime);
        }
    }

    public void GoToDestiny()
    {
        CanMove = true;
    }
    private void MoveToDestiny()
    {
        if (llegoAlBordeInf && llegoAlBordeSup)
        {
            if (!saltoSup) SaltarHaciaAdelante();
            transform.position = Vector3.MoveTowards(transform.position, Destiny.position, 1 * Time.deltaTime);
        }
    }

    public void CollisionDetected(string value)
    {
        if (value.ToLower() == "inf")
        {
            llegoAlBordeInf = true;
        }
        else if (value.ToLower() == "sup")
        {
            llegoAlBordeSup = true;
        }
        else if (value.ToLower() == "destiny")
        {
            saltoSup = true;
        }
    }
}
