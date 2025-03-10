using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wand : Tool
{
    public GameObject pinkBall;
    public GameObject ballSpawn;
    public override void Activate()
    {
        Instantiate(pinkBall, ballSpawn.transform.position, ballSpawn.transform.rotation);
    }
}
