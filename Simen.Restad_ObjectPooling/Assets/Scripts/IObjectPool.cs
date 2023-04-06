using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
// Modified by Tamer Ayoub 4/1/2023;
// This tell us how we wished the original class worked
// These methods are how we wish the original class was set up
public interface IObjectPool
{

    // this is the method we are adapting that is from the orignal ObjectPool class, but now will be used in the new adapted class
    GameObject GetPooledObject(Click click);

}
