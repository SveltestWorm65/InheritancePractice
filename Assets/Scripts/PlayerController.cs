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

    public GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
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
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            gm.UpdateHealth(-3);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("EnemyProjectile"))
        {
            gm.UpdateHealth(-1);
            Destroy(collision.gameObject);
        }
    }
}
