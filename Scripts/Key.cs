using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Pickups
{
    private GameManager gm;
     
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)//other is  local variable recording collision in other
    {  
        //Pickup key script
        if(other.gameObject.CompareTag("Player"));
        {
            gm.AddKey(amount);//adds object to inventory
            Destroy(gameObject);//Destroys pickup
        }
    }
}
