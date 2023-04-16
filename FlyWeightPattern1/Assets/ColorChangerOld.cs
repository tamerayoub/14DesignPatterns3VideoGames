using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Modified by Tamer Ayoub 4/16/23, this is old way of chaning colors ( The Fly Weight Pattern )

public class ColorChangerOld : MonoBehaviour
{
    private Renderer renderedObject;

    void Awake()
    {
        // This lets us access the renderer componenet of an object, which gives us access to manipulate the material
        renderedObject = GetComponent<Renderer>();
       
    }

    void Update()
    {
        Color randomColor = Random.ColorHSV(); // Generate a random color using HSV color space

       
        renderedObject.material.color = randomColor; // Apply the random color to all renderers in the scene, adding materials to each object
        
    }
}
