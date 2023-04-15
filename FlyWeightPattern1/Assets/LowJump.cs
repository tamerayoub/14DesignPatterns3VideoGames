using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LowJump : Jumping
{

    public override void Activate(string name)
    {
        Jump(5, name);
    }
}

