using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is one of the variations of jumping ( SandBox Pattern ) - Modified by Tamer Ayoub
public class HighJump : Jumping
{
    
    public override void Activate(string name)
    {
        Jump(10, name);
    }
}

