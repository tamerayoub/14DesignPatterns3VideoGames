// created by Qusai Fannoun and Tamer Ayoub
//03/08/2023

//this class is the subclass that inherit from the TurretBlueprintV2
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class StandardTurret : TurretBlueprintV2
{
    int aCost = 100;
    int aUpgradeCost = 60;
    public StandardTurret()
    {
        Cost = aCost;
        UpgradeCost = aUpgradeCost;
        SellAmount = aCost / 2;
    }

}
