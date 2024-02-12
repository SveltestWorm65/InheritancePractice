using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class GameManager : MonoBehaviour
{
    public int startingHealth;
    public int health = 0;
    public TextMeshProUGUI healthDisplay;
    public int startingAmmo;
    public int ammo = 0;
    public TextMeshProUGUI ammoDisplay;


    // Start is called before the first frame update
    void Start()
    {
        UpdateHealth(startingHealth);
        UpdateAmmo(startingAmmo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateAmmo(int ammoToAdd)
    {
        ammo += ammoToAdd;
        ammoDisplay.text = $"Ammo: {ammo}";
    }

    public void UpdateHealth(int healthToAdd)
    {
        health += healthToAdd;
        healthDisplay.text = $"Health: {health}";
    }
}
