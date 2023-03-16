using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int key;
    public int gem;
    
    public void AddKey(int amount)
    {
        key += amount; //adds keys 
        //if there was a UI to update it would go in this section
        Debug.Log("Keys = "+ key); //tells how many keys are currently in inventory
    }
    public void AddGem(int amount)
    {
        gem += amount;
        Debug.Log("Gems ="+ gem);
    }
    //public void AddTrophy(int amount)
    
        //trophy += amount;
        //Debug.Log("Trophy ="+ trophy);
    
}
