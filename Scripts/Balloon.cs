using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int scoreToGive = 100; // score given for pop
    public int clickToPop = 3; //how many clicks before pop
    public float scaleToIncrease = 0.10f; //scale increase per click
    public ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
      scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); 
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        //reduce clicks by one
        clickToPop -= 1;
        //Increase Balloon volume
        transform.localScale += Vector3.one * scaleToIncrease;
        
        if(clickToPop == 0)
        {
            scoreManager.IncreaseScoreText(scoreToGive);
            Destroy(gameObject);
        }
    }
}
