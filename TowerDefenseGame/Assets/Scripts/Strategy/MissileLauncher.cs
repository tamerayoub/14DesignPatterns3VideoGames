// created by Qusai Fannoun and Tamer Ayoub
//03/08/2023

//this class is the subclass that inherit from the TurretBlueprintV2
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileLauncher : TurretBlueprintV2
{
   
    int aCost = 250;
    int aUpgradeCost = 150;
    public MissileLauncher()
    {
        Cost = aCost;
        UpgradeCost = aUpgradeCost;
        SellAmount = aCost / 2;
    }
}
