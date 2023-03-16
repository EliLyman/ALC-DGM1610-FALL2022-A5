using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool hasFlag;
    public bool placedFlag;
    
    // Start is called before the first frame update
    void Start()
    {
        hasFlag = false;
        placedFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(placedFlag)
        {
            WinGame();
        }
    }
    
    public void PlacedFlag()
    {
        if(hasFlag)
        {
            placedFlag = true;
            Debug.Log("Flag has been placed at home base");
        }
    }
    public void WinGame()
    {
        Debug.Log("you did a win");
        //Time.timeScale = 0;
    }
}
