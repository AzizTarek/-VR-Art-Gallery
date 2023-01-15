using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource[] audioSources;

    void OnTriggerEnter(Collider col)
    {
        foreach (AudioSource aSource in audioSources)
        {
            aSource.enabled = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        foreach (AudioSource aSource in audioSources)
        {
            aSource.enabled = false;
        }
    }

}
