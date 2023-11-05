using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HormigaBehaviour : MonoBehaviour
{
    [SerializeField] Transform Destiny;
    [SerializeField] public bool CanMove = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CanMove)
        {
            transform.position = Vector3.MoveTowards(transform.position, Destiny.position, 1 * Time.deltaTime);
        }
    }
    
}
