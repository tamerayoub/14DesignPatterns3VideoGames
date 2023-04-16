// created by Qusai Fannoun on 15/04/2023
// this is the Turret controller that also inherit from the singleton class1
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : Singleton<TurretController>
{

    // private List<ITurretElement> turretElements = new List<ITurretElement>();

    // private void Start()
    // {
    //     turretElements.Add(GameObject.FindObjectOfType<Turret>());
    // }

    public void Accept(IVisitor aVisitor)
    {
        var ITurretElements = FindObjectsOfType<Turret>(); ;
        foreach (ITurretElement turretElement in ITurretElements)
        {
            turretElement.Accept(aVisitor);
        }
    }
}
