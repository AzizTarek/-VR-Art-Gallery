using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleKey : MonoBehaviour //Makes a GameObject such as a key collectible
{
    public GameObject key; //A gameoobject
    public AudioSource audioSource;
    public bool collected = false; // indicates that this gameobject has been collected under a certain a scenario
    public bool incrementedTheArray = false; // indicates if this gameobject has already been coutned in the array
    public bool isGreenKey = false; // indicates that this object(key) is a green key
    public bool isRedKey = false; // indicates that this object(key) is a red key
    public PlayerManager pManager; // player manager class object
    public bool keyDestroyed = false;
   
    void OnTriggerEnter(Collider col) // detect collision
    {       
        Debug.Log("hit detected"); // Debug info
        audioSource.Play();

        collected = true; // indicate that this object has been collected
        pManager.UpdateHUDText(isGreenKey,isRedKey); // Update the text on the hud
        key.SetActive(false); // disable the key's visibility
        incrementedTheArray = true; // the array will be incremented only once

        keyDestroyed = true;
        Destroy(gameObject); // destroy the object
    }


}
