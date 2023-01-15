using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public TextMeshProUGUI hudTextRedKeys; // Text shown in the HUD
    public TextMeshProUGUI hudTextGreenKeys; // Text shown in the HUD

    public CollectibleKey[] keys; // The collectible gameobjects
    private int redKeys_no; // the number of red keys
    private int greenKeys_no; // the number of green keys

    public GameObject leosRoom; // The parent gameobject that holds all the objects of 'leos room'

    public GameObject leoRoomMenuOption_locked; // show that leo's room cannot be accessed using a ui element
    public GameObject leoRoomMenuOption_unlocked; // show that leo's room can be accessed  using a ui element



   


    public void UpdateHUDText(bool isGreenKey, bool isRedKey ) //Update the text shown in the player's HUD
    {
        //foreach ( CollectibleKey key in keys)
        //{
        //    if (key.collected) // if the key has been collected
        //    {
        //        if (!key.incrementedTheArray)
        //        {
        //            if (key.isGreenKey)
        //                greenKeys_no++; // if a green key was collected then increment this int 
        //            else if (key.isRedKey)
        //                redKeys_no++; // if a red key was collected then increment this int 

        //            hudTextRedKeys.enabled = true;
        //            hudTextGreenKeys.enabled = true;
        //            hudTextRedKeys.SetText("Red Keys: " + redKeys_no);
        //            hudTextGreenKeys.SetText("Green Keys: " + greenKeys_no);
        //            key.incrementedTheArray = true; // the array will be incremented only once
        //        }
             

        //    }
        //}

      
                    if (isGreenKey)
                        greenKeys_no++; // if a green key was collected then increment this int 
                    else if (isRedKey)
                        redKeys_no++; // if a red key was collected then increment this int 

                    hudTextRedKeys.enabled = true;
                    hudTextGreenKeys.enabled = true;
                    hudTextRedKeys.SetText("Red Keys: " + redKeys_no);
                    hudTextGreenKeys.SetText("Green Keys: " + greenKeys_no);
        


        if (redKeys_no>= 9 && greenKeys_no>= 8)
        {
            leosRoom.SetActive(true);//enable leonardo's building
            leoRoomMenuOption_locked.SetActive(false); // disable picture in the menu that shows leo's room is locked
            leoRoomMenuOption_unlocked.SetActive(true); // enable picture in the menu that shows leo's room is unlocked

            // disable the hud text as the player no longer need keep tracks of it
            hudTextRedKeys.enabled = false; 
            hudTextGreenKeys.enabled = false;
        }
    }



}
