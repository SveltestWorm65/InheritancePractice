using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Movement
    public float speed;
    private float verticalInput;
    private float horizontalInput;

    //Limits
    public float xLimit;
    public float yLimit;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(((Vector2.up * verticalInput) + (Vector2.right * horizontalInput)) * speed * Time.deltaTime);

        //Limitation
        if(transform.position.x > xLimit)
        {
            transform.position = new Vector2(xLimit, transform.position.y);
        }
        if (transform.position.x < -xLimit)
        {
            transform.position = new Vector2(-xLimit, transform.position.y);
        }
        if (transform.position.y > yLimit)
        {
            transform.position = new Vector2(transform.position.x, yLimit);
        }
        if (transform.position.y < -yLimit)
        {
            transform.position = new Vector2(transform.position.x, -yLimit);
        }

    }
}
