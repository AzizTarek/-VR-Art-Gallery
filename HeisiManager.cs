using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeisiManager : MonoBehaviour
{
    public Animator anim;
    public AudioSource aSource;
    public bool wasRunOnce= false; // boolean to indicate that the animation cycle was run once

    void OnTriggerEnter(Collider col)
    {
       
        if (wasRunOnce)
        {
            aSource.enabled = false;
            anim.SetBool("isRunning", false); // set animation to idle

        }
        else
        {
            anim.SetBool("isRunning", true); // run animations
            aSource.enabled = true;

        }

    }

    void OnTriggerStay(Collider col)
    {
        if (!aSource.isPlaying)
            wasRunOnce = true;
    }

    void OnTriggerExit(Collider col)
    {
      anim.SetBool("isRunning", false); // set animation to idle
        aSource.enabled = false;

    }
}
