using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public float deathDelay;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update() //clean out code that isnt being used like this void update :P
    {
        
    }
    public void takeDamage(int dmgAmount)
    {
        currentHealth -= dmgAmount;
        
        if(currentHealth <= 0)
        {
            //Destroy(gameObject,deathDelay); //run out of lives you die
            Debug.Log("You have died nerd :P");
            Time.timeScale = 0;
        }
    }
    public void AddHealth(int healAmount)
    {
        currentHealth += healAmount;
        
        if(currentHealth >= maxHealth) //caps max healing
        {
            currentHealth = maxHealth;
        }
    }
    
}
