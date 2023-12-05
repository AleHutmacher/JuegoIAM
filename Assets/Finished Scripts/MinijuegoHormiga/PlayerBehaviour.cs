using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    /*[SerializeField] Transform BordeAcantiladoInf;
    [SerializeField] bool llegoAlBordeInf = false;
    [SerializeField] Transform BordeAcantiladoSup;
    [SerializeField] bool llegoAlBordeSup = false;
    [SerializeField] Transform Destiny;
    [SerializeField] bool CanMove = false;
    [SerializeField] Transform RamaTransform;
    private bool saltoInf = false;
    private bool saltoSup = false;*/

    private Rigidbody2D rb2d;

    public Transform destiny;

    [SerializeField] float minDistance;
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    [SerializeField] float gravityForce;

    bool destinyReached;
    bool canMove;

    private void Start()
    {
        destinyReached = false;

        canMove = false;

        rb2d = GetComponent<Rigidbody2D>();

        rb2d.gravityScale = gravityForce;
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            Move();
        }
    }

    public void StartMovement()
    {
        canMove = true;
    }

    void Move()
    {
        if (Vector2.Distance(transform.position, destiny.position) > minDistance)
        {
            rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
        }
        else
        {
            triggerEnd();
        }
    }

    void Jump()
    {
        rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);
        Debug.Log("salto realizado");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("JumpPoint"))
        {
            Jump();
        }
    }

    void triggerEnd()
    {
        if (!destinyReached)
        {

            destinyReached = true;
        }
    }
}
