using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code makes the object switch textures overtime

public class ChangeMaterial : MonoBehaviour
{
    public Material[] materials; //Array of materials to switch between
    public float switchInterval = 2.0f; //Time interval between material switches
    private float timeSinceSwitch = 0.0f; //Time since last material switch
    private int currentMaterialIndex = 0; //Index of the current material being used

    private Renderer objectRenderer; //Reference to the object's renderer component

    void Start()
    {
        //Get the renderer component attached to the game object
        objectRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        //Increment the time since the last material switch
        timeSinceSwitch += Time.deltaTime;

        //Check if it's time to switch the material
        if (timeSinceSwitch >= switchInterval)
        {
            //Reset the time since the last switch
            timeSinceSwitch = 0.0f;

            //Switch to the next material in the array
            currentMaterialIndex = (currentMaterialIndex + 1) % materials.Length;
            objectRenderer.material = materials[currentMaterialIndex];
        }
    }
}