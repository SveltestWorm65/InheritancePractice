using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    protected Rigidbody2D rb;

    public GameObject Player;
    public GameManager gm;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Player = GameObject.Find("Player");
        
    }

    // Update is called once per frame
    protected virtual void FixedUpdate()
    {
        Vector2 lookDirection = (Player.transform.position - transform.position).normalized;
        rb.AddForce( lookDirection * speed);

       
    }
    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Projectile"))
        {
            Destroy(gameObject);
        }
    }
}
