using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : Pickups
{
    private GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

  void OnTriggerEnter2D(Collider2D other)//other is  local variable recording collision in other
    {  
        //Pickup gem script
        if(other.gameObject.CompareTag("Player"));
        {
            gm.AddGem(amount);//adds object to inventory
            Destroy(gameObject);//Destroys pickup
        }
    }
}

