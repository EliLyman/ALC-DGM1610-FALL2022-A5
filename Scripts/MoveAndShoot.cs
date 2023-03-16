using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndShoot : MonoBehaviour
{
    public float speed;
    public float stopDistance;
    public float retreatDistance; //enemy run away from player
    private Transform target;
    private float shotDelay;
    public float startDelay;
    
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        shotDelay = startDelay;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) >stopDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime); //Keep moving
        }
        else if(Vector2.Distance(transform.position, target.position) < stopDistance && Vector2.Distance(transform.position, target.position) > retreatDistance)
        {
            transform.position = this.transform.position; //stay in place
        }
        else if(Vector2.Distance(transform.position, target.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, -speed * Time.deltaTime); //RETREAT!!!
        }
        if(shotDelay <= 0)
        {
            Attack();
        }
        else
        {
            shotDelay -= Time.deltaTime;
        }
        }
        
        void Attack()
        {
            if(Vector2.Distance(transform.position, target.position) > stopDistance)
            {
                transform.position = this.transform.position;//stay put
                Instantiate(projectile, transform.position, Quaternion.identity); //fire projectiles
                shotDelay = startDelay; //reset shot delay
            }
        }
        
}
