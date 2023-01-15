using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fix_Menu : MonoBehaviour
{
    void Start() //fix menu after returning to it from the game scene
    {
        Cursor.visible = true; Cursor.lockState = CursorLockMode.None; //After coming back to the main menu from a scene, menu can be clicked (its a fix to this issue)
    }
}
