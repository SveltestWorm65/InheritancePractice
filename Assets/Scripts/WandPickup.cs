using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandPickup : Pickup
{
    public GameObject wandPrefab;
    protected override void ActivatePickup()
    {
        GameObject.Find("Player").GetComponent<ToolControl>().UpdateTool(wandPrefab);
    }
}
