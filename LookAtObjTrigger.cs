using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LookAtObjTrigger : MonoBehaviour
{

    
    public GameObject informationPanel; // panel that holds all the text
    private bool panelEnabled = false; // indicates that the panel is disabled
    public GameObject key; // a collectible gameObject named key
    public bool keyIsDestroyed = false;
    public CollectibleKey ck;


   
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
           
           if (!ck.keyDestroyed)
                StartCoroutine(ReleaseKey()); // while it is still enabled release key after 5 seconds
            else
                StopCoroutine(ReleaseKey());

        }
        else
             informationPanel.SetActive(false);
         
    }


    IEnumerator ReleaseKey() //Releases the Key gameObjects after a specified amount of time
    {
        yield return new WaitForSeconds(5); // wait for 5 seconds before releasing the key to make it collectable
        if (!ck.keyDestroyed)
            key.SetActive(true);
    }



}
