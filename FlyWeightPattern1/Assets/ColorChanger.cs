using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This script contains our FlyWeight Pattern - Modified by Tamer Ayoub
public class ColorChanger : MonoBehaviour
{

    // the renderer class is what makes an object appear on the screen. 
    private Renderer renderedObject;


    // Awake is used to initialize any variables or game state before the game starts. Awake is called only once during the lifetime of the script instance.
    void Awake()
    {
        // This lets us access the renderer componenet of an object, which gives us access to manipulate the material
        renderedObject = GetComponent<Renderer>();
        //  Use MaterialPropertyBlock in situations where you want to draw multiple objects with the same material
        propBlock = new MaterialPropertyBlock();
    }

    // Update is called once per frame
    
    // This function returns a random color
    private Color GetRandomColor()
    {
        return new Color(
            Random.Range(0f, 1f),
             Random.Range(0f, 1f),
            Random.Range(0f, 1f)
            );
    }


    // instantiates propBlock using MaterialPropertyBlock, so the most efficient way of using it is to create one block and reuse it for all calls
    private MaterialPropertyBlock propBlock;


    void Update()
    {
        renderedObject.GetPropertyBlock(propBlock); // The retrieved properties are stored in the property block passed in through "properties".
        propBlock.SetColor("_Color", GetRandomColor()); // set the prop block w/ a random color
        renderedObject.SetPropertyBlock(propBlock); // set the renderedObject with the new prop block color
    }



}
