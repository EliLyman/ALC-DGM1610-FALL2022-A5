using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float attackDelay;
    public float startDelay;
    public Transform attackPos;
    public LayerMask whatIsEnemies;
    public float attackRange;
    public int damage;
    
    // Start is called before the first frame update
    void Update()
    {
        if(attackDelay <= 0 ) //conditional
        {
            if(Input.GetKey(KeyCode.Space)) //[] is to declare an array
            {
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
                
                for(int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<EnemyHealth>().takeDamage(damage);
                }
            }
            attackDelay = startDelay;
        }
        else
        {
            attackDelay -= Time.deltaTime; //counting down
        }
    }
    
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
}
