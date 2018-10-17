using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDAnimationObject : MonoBehaviour {

    //Reference the Animator component
    Animator animator;
    
    //Plays the animation using passed string as the name
    void  PlayAnimation(string s)
    {
        animator.Play(s);
    }

    //Stops the animation
    void StopAnimation()
    {
        animator.StopPlayback();
    }

    //Added to allow the Aniamtion, of whatever string is passed, to be turned on
    public void ActivateAnimationBool(string s)
    {
        GetComponent<Animator>().SetBool(s,true);
    }

    //Added to allow the Aniamtion, of whatever string is passed, to be turned off
    public void DeactivateAnimationBool(string s)
    {
        GetComponent<Animator>().SetBool(s, false);
    }
}
