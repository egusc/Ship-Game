using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float turningSpeed;
    private Vector3 direction;
    private Rigidbody2D rb;
    void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");


//Get the value of the Horizontal input axis.

        if(horizontalInput > 0)
        {
            transform.Rotate(0f,0f,-turningSpeed);
        } else if(horizontalInput < 0)
        {
            transform.Rotate(0f,0f,turningSpeed);
        }

        if(verticalInput > 0)
        {
            rb.MovePosition(transform.position + moveSpeed * Time.deltaTime * transform.up);
            Vector3 position = transform.position;

            float distance = transform.position.z - Camera.main.transform.position.z;

            float leftBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance)).x + 0.2f;
            float rightBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distance)).x - 0.2f;
            float topBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance)).y + 0.2f;
            float bottomBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, distance)).y - 0.2f;

            position.x = Mathf.Clamp(position.x, leftBorder, rightBorder);
            position.y = Mathf.Clamp(position.y, topBorder, bottomBorder);
            transform.position = position;
            /*if(transform.position.x < 0.4f)
            {
                transform.position = new Vector3 (0.4f, transform.position.y, transform.position.z);
            }*/
        }
    }
}
