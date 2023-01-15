using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LookAtObjTrigger2 : MonoBehaviour // copy of lookatobjtrigger without a gameobject(key) as a field
{

    
    public GameObject informationPanel; // panel that holds all the text
    private bool panelEnabled = false; // indicates that the panel is disabled
   
    void Update()
    {
            // Is user looking here?
            Transform camera = Camera.main.transform;
            Ray ray = new Ray(camera.position, camera.TransformDirection(Vector3.forward));
            RaycastHit hit;
        if (Physics.Raycast(ray, out hit) && (hit.collider.gameObject == gameObject)) // if the raycast hits the game object
        {
           panelEnabled = true;
        }
        else
        {
            panelEnabled = false;

        }
        InfoPanel();  // trigger canvas panel



    }


    void InfoPanel()
    {
        if (panelEnabled) 
        {
            informationPanel.SetActive(true); //enable panel
        }
        else
             informationPanel.SetActive(false);
         
    }



}
