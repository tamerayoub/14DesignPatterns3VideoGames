using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HighJump : Jumping
{
    
    public override void Activate(string name)
    {
        Jump(10, name);
    }
}

