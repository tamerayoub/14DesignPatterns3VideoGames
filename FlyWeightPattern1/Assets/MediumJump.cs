using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is one of the variations of jumping ( SandBox Pattern ) - Modified by Tamer Ayoub

public class MediumJump : Jumping
{
    // you can see this class is inheriting from the parent class 'Jumping', we take the name of object we want to jump medium with and we send the name and vertical to the Jump method we inherited
    public override void Activate(string name)
    {
        Jump(1.5f, name);
    }
}

