using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class GameController : MonoBehaviour
{

    HighJump highJump = new HighJump();
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
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
           
            lowJump.Activate("Homer");
            audioData.Play();
        }
        if (Input.GetKeyDown("r"))
        {
         
            highJump.Activate("Spongebob");
            audioData2.Play();
        }

        if (Input.GetKeyDown("t"))
        {

            highJump.Activate("Bunny");
            audioData3.Play();
        }
    }
}
