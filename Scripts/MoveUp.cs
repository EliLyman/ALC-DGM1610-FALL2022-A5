using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public float moveSpeed= 1.0f;
    public float upperBound = 25.0f;
    private Balloon balloon;
    public ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        balloon = GetComponent<Balloon>(); //reference to balloon obj
    }

    // Update is called once per frame
    void Update()
    {
       //move balloon up
       transform.Translate(Vector3.up * moveSpeed * Time.deltaTime); 
       
       //destroy balloon after it passes the upperbound
       if(transform.position.y > upperBound)
    
    Destroy(gameObject);
    }
}