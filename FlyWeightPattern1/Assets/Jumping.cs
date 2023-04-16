using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is the parent class where we handle the multiple variations of jumping ( SandBox Pattern ) - Modified by Tamer Ayoub

public abstract class Jumping
{
    // We use this activate method in the child classes
    public abstract void Activate(string name);
    public string name;
    

    // This is the main method for the SandBox pattern; we have different variations like LowJump and HighJump
    protected void Jump(float vertical, string name) 
    {

        
        GameObject player;
        


        // whatever object name tag we called activate with, grab it
        player = GameObject.FindWithTag(name);
        // and add force to jump
        player.GetComponent<Rigidbody>().AddForce(vertical * Vector3.up, ForceMode.VelocityChange);
       

    }


}
