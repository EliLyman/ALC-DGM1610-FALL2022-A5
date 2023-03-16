using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeBase : MonoBehaviour
{
    private Renderer flagRend;
    private GameManager gm;
    
    
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        flagRend = GameObject.Find("FlagHome").GetComponent<Renderer>(); //mindful of names
        
        flagRend.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && gm.hasFlag)
        {
            gm.PlacedFlag();
            Debug.Log("home base reached");
            flagRend.enabled = true; ///shows flag at home base
        }
    }
}
