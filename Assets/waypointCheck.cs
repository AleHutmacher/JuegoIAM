using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypointCheck : MonoBehaviour
{
    bool checkedPosition;

    private void Start()
    {
        checkedPosition = false;
    }

    bool GetCheckedPosition()
    {
        return checkedPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Waypoint"))
        {
            checkedPosition = true;
        }
    }
}
