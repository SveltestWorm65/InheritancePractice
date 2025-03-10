using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedEnemy : Enemy
{
   
    public GameObject Projectile;
    public GameObject projectileSpawn;
    protected override void Start()
    {
        base.Start();
        StartCoroutine(Shooting());
    }
    
       
    
    protected override void FixedUpdate()
    {
        Vector2 lookDirection = (Player.transform.position - transform.position).normalized;
        rb.AddForce(lookDirection * speed);

    }
    protected IEnumerator Shooting()
    {
        yield return new WaitForSeconds(0);
        Instantiate(Projectile, projectileSpawn.transform.position, projectileSpawn.transform.rotation);
        yield return new WaitForSeconds(3);
        StartCoroutine(Shooting());
    }
}
