using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public abstract class Jumping
{

    public abstract void Activate(string name);
    public string name;

    protected void Jump(float vertical, string name)
    {

        
        GameObject player;
        GameObject player2;



        player = GameObject.FindWithTag(name);
        /*player2 = GameObject.FindWithTag("Spongebob");*/
        player.GetComponent<Rigidbody>().AddForce(vertical * Vector3.up, ForceMode.VelocityChange);
        /*player2.GetComponent<Rigidbody>().AddForce(vertical * Vector3.up, ForceMode.VelocityChange);*/

    }


}
