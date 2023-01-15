using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform camera;
    public GameObject player;


    //Teleport points
    public Transform mainGallery;
    public Transform leosRoom;
    public Transform garden;
    public Transform bigStatues;

    // Start is called before the first frame update
    void Start()
    {
       // camera = Camera.main.transform;
    }


    public void TeleportToMainGallery()
    {
        player.transform.position = mainGallery.transform.position; // change my cuurrent location to the spawn point in the gallery
       
    }

    public void TeleportToLeosRoom()
    {
       // transform.position = leosRoom.position; // change my cuurrent location to the spawn point in leo's room
        player.transform.position = leosRoom.transform.position; // change my cuurrent location to the spawn point in the gallery

    }

    public void TeleportToGarden()
    {
        //transform.position = garden.position; // change my cuurrent location to the spawn point in the garden
        player.transform.position = garden.transform.position; // change my cuurrent location to the spawn point in the gallery

    }

    public void TeleportToBigStatues()
    {
      //  transform.position = bigStatues.position; // change my cuurrent location to the spawn point in the big statues area
        player.transform.position = bigStatues.transform.position; // change my cuurrent location to the spawn point in the gallery

    }
}
