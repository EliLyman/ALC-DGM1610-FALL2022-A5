using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    
    public float speed; //how fast the enemy goes
    public float stopDistance; //how far away from the player the enemy stops
    private Transform target; // specifically moving the target
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) > stopDistance) //takes position of enemy and target end point
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime); //perameters set for stopDistance, moves the enemy towards the player at a set speed
        }
        
    }
}
