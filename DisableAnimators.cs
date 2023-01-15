using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAnimators : MonoBehaviour
{
    public Animator[] animators;

    void OnTriggerEnter(Collider col)
    {
        foreach (Animator anim in animators)
        {
            anim.enabled = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        foreach (Animator anim in animators)
        {
            anim.enabled = false;
        }
    }

}
