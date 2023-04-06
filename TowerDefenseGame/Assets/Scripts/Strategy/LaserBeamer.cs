// created by Qusai Fannoun and Tamer Ayoub
//03/08/2023


//this class is the subclass that inherit from the TurretBlueprintV2
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBeamer : TurretBlueprintV2
{

    int aCost = 350;
    int aUpgradeCost = 200;
    public LaserBeamer()
    {
        Cost = aCost;
        UpgradeCost = aUpgradeCost;
        SellAmount = aCost / 2;
    }
}
