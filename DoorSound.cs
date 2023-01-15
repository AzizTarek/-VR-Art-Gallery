using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSound : MonoBehaviour
{
    public AudioClip doorOpen;
    public AudioClip doorClose;


    public void PlayDoorOpenAudio() // plays audio and is disposed afterward, it is used as an animation event of a door animation
    {
        AudioSource.PlayClipAtPoint(doorOpen, transform.position); // Door open sound effect is played
    }

    public void PlayDoorCloseAudio() // plays audio and is disposed afterward, it is used as an animation event of a door animation
    {
        AudioSource.PlayClipAtPoint(doorClose, transform.position);// Door close sound effect is played
    }
}
