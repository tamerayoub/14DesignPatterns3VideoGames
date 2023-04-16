using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Asteroid : MonoBehaviour
{
    public abstract float Speed
    {
        get;
    }

    public abstract float RotationSpeed
    {
        get;
    }
}
