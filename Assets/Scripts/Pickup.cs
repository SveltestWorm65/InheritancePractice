using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    protected GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    protected virtual void ActivatePickup()
    {
        Debug.Log("Pickup Activated");
    }

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            ActivatePickup();
            Destroy(gameObject);
        }
    }
}
