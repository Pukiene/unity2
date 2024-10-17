using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Health_Bar2 : MonoBehaviour 
{
    public static event Action OnPlayerDeath;

    public int maxHealth = 4;
    public int currentHealth; 
    public Halth_bar healthbar;

    private bool takeHealth;

    void Start()
    {   
        currentHealth = maxHealth;
         
        // Debug.Log("a1 " + maxHealth.ToString() + "currentHealth " + currentHealth.ToString());
        healthbar.SetMaxHelth(maxHealth);
    
    }

    
    void Update()
    {
        
        if (GameObject.FindWithTag("Player").transform.position.y <= -10 && takeHealth == true) 
        {
            TakeDamage(1);
          //  Debug.Log ("veikia1");
          //Debug.Log ("------");
          takeHealth = false;
        }
        if (GameObject.FindWithTag("Player").transform.position.y >= -5  && takeHealth == false) 
        {
            
            //Debug.Log ("++++=");
            takeHealth = true;
        }
    }

    void TakeDamage(int damage)
    {
        
        //damage = Mathf.Clamp(damage, 0, currentHealth);  
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
        
        if (currentHealth <= 0)        
       // {
       //  Debug.Log ("veikia");   // Handle player death or game over state (not shown here)
       // }
        {
       OnPlayerDeath?.Invoke();
       }
    }
}
