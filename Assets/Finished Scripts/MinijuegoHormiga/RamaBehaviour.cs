using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RamaBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateRotation(float value)
    {
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, value);
    }
    public void UpdateOrdenadaOrigen(float value)
    {
        transform.position = new Vector3(transform.position.x, value, transform.position.z);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Piedra") && collision.GetComponent<PiedraBehaviour>().CanDestroy())
        {
            collision.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}


