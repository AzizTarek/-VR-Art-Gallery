using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
   public Animator doorAanim;
   public Animator doorBanim;


    void OnTriggerEnter(Collider col) // detect collision
    {
        //if (col.gameObject.tag == "Player")
        {
            Debug.Log("hit detected");
           doorAanim.SetBool("DoorIsOpen", true); // enable door open animation
           doorBanim.SetBool("DoorIsOpen", true); // enable door open animation

        }
    }


    void OnTriggerStay(Collider col) // detect collision
    {
        //if (col.gameObject.tag == "Player")
        {
            Debug.Log("hit detected");
            doorAanim.SetBool("DoorIsOpen", true); // enable door open animation
            doorBanim.SetBool("DoorIsOpen", true); // enable door open animation

        }
    }
    void OnTriggerExit(Collider col) // detect the exit from a current ongoing collision
    {
           
       // if (col.gameObject.tag == "Player")
        {
            Debug.Log("exited the collider");
            doorAanim.SetBool("DoorIsOpen", false); // enable door close animation
            doorBanim.SetBool("DoorIsOpen", false); // enable door close animation

        }
    }
}
