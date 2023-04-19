using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Modified by Tamer Ayoub; Sandbox Pattern


public class GameController : MonoBehaviour
{

    HighJump highJump = new HighJump();
    MediumJump mediumJump = new MediumJump();
    LowJump lowJump = new LowJump();

    private AudioSource audioData;

    private AudioSource audioData2;

    private AudioSource audioData3;
    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        audioData2 = GetComponent<AudioSource>();
        audioData3 = GetComponent<AudioSource>();
    }

   


    // Update is called once per frame

    // Down below is our input handler for the SandBox Pattern; we have 3 characters and we need to add jumping ability to all of the characters, but all of their jumping skills are different...
    // Follow along and you will see how we added different variations to each of the characters
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
           
            highJump.Activate("Homer");
            audioData.Play();
        }
        if (Input.GetKeyDown("r"))
        {
         
            mediumJump.Activate("Spongebob");
            audioData2.Play();
        }

        if (Input.GetKeyDown("t"))
        {

            mediumJump.Activate("Bunny");
            audioData3.Play();
        }


    }
}
