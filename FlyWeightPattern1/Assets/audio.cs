using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{

    AudioSource audio3;
    // Start is called before the first frame update
    void Start()
    {
        audio3 = GetComponent<AudioSource>();
        audio3.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
