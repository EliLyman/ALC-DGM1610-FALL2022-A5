using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 2;
    public int currentHealth;
    public float deathDelay;
    private Renderer renderer;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        Time.timeScale = 1;
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update() //clean out code that isnt being used like this void update :P
    {
        
    }
    public void takeDamage(int dmgAmount)
    {
        currentHealth -= dmgAmount;
        renderer.material.color = Color.red;
        
        if(currentHealth <= 0)
        {
            Destroy(gameObject); //run out of lives you die
            Debug.Log("enemy died what a nerd :P");
        }
    }
   }
