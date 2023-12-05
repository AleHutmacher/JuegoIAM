using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypointCheck : MonoBehaviour
{
    [SerializeField]bool checkedPosition;

    private void Start()
    {
    }

    public bool GetCheckedPosition()
    {
        return checkedPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Waypoint"))
        {
            Debug.Log("colision wayp");
            checkedPosition = true;
        }
    }

    /*private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Waypoint"))
        {
            checkedPosition = false;
        }
    }*/
}
