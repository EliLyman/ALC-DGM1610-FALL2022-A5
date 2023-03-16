using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed; // How fast the player moves
    
    public float hInput; //Horizontal
 
    public float vInput; //Vertical input
    
 // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
            
        vInput = Input.GetAxis("Vertical");
        // move left and right
        
        transform.Translate(Vector2.right * hInput * speed * Time.deltaTime);
        
        transform.Translate(Vector2.up * vInput * speed * Time.deltaTime);
        // move up and down
    }
}