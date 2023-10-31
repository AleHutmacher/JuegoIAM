using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ramaController : MonoBehaviour
{
    public float a = 1.0f; // Puedes ajustar estos valores según tus necesidades
    public float b = 0.0f;

    public float rotationSpeed = 1.0f;
    public float positionSpeed = 0.1f;

    public Button lessRotationBt, moreRotationBt, lessPositionBt, morePositionBt;

    private buttonPressed lessRotation, moreRotation, lessPosition, morePosition;
    private Rigidbody2D rb2d;

    private float currentRotation = 0f;

    private void Start()
    {
        lessRotation = lessRotationBt.GetComponent<buttonPressed>();
        moreRotation = moreRotationBt.GetComponent<buttonPressed>();
        lessPosition = lessPositionBt.GetComponent<buttonPressed>();
        morePosition = morePositionBt.GetComponent<buttonPressed>();

        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (moreRotation.getIsPressed() && currentRotation > -90)
        {
            IncreaseRotation();
        }
        else if (lessRotation.getIsPressed() && currentRotation < 90)
        {
            DecreaseRotation();
        }           
    }

    private void FixedUpdate()
    {
        if (morePosition.getIsPressed())
        {
            IncreasePosition();
        }
        else if (lessPosition.getIsPressed())
        {
            DecreasePosition();
        }
        else
        {
            rb2d.velocity = new Vector2(0, 0);
        }
    }

    public void IncreasePosition()
    {
        rb2d.velocity = transform.right * positionSpeed;
    }

    public void DecreasePosition()
    {
        rb2d.velocity = -transform.right * positionSpeed;
    }

    public void IncreaseRotation()
    {
            currentRotation -= rotationSpeed;
            currentRotation = Mathf.Clamp(currentRotation, -90, 90);
            transform.rotation = Quaternion.Euler(0, 0, currentRotation);
    }

    public void DecreaseRotation()
    {
            currentRotation += rotationSpeed;
            currentRotation = Mathf.Clamp(currentRotation, -90, 90);
            transform.rotation = Quaternion.Euler(0, 0, currentRotation);
    }
}