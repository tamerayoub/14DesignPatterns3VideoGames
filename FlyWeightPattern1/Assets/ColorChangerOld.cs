using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
