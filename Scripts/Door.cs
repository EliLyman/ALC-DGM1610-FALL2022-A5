using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{   //access modifier, variable, class type
    private GameManager gm;
    public float doorDelay; //s you dont want to hard code
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player") && gm.key >= 1)
        {
            Destroy(gameObject, doorDelay); 
            gm.key --;
            Debug.Log("Keys = "+gm.key);
            Debug.Log("The door is open");
        }
        else
        {
            Debug.Log("The door is locked a key is needed to progress");
        }
    }
      
}