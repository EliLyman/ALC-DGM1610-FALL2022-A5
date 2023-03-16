using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnimationController : MonoBehaviour
{
    public Animator animSpeed;
    public Animation anim;
    
    // Start is called before the first frame update
    void Start()
    {
        //Get Animator and Animation Componenets
        animSpeed = GetComponent<Animator>();
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
            PlayAnim();
        
        if(Input.GetKeyDown(KeyCode.O))
            StopAnim();
        
    }
    //Control Animation via animator and Key/button presses
    void PlayAnim()
    {
       animSpeed.speed = 1f;
       Debug.Log("Animation is Playing");
    }
    void StopAnim()
    {
    animSpeed.speed = 0f; //f is for floating variable
    Debug.Log("Animation has paused");
    }
    //Control animation via animation clip and buttons
    public void PushPlay()
    {
        anim.Play();
    }
    public void PushStop()
    {
        anim.Stop();
    }
}
