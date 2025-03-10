using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : Pickup
{
    public int healthAmount;
    protected override void ActivatePickup()
    {
        gm.UpdateHealth(healthAmount);
    }
}
