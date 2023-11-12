using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiedraBehaviour : MonoBehaviour
{
    [SerializeField] Timer timer;

    bool canDestroy = false;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.getFinishedCountdown())
        {
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            canDestroy = true;
        }
    }

    public bool CanDestroy()
    {
        return canDestroy;
    }
}
