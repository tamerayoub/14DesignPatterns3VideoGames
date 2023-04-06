// created by Qusai Fannoun and Tamer Ayoub on 03/08/2023
// this is the super class that the other turrets will inherit from.
// this class is responsible for buying, selling , and upgrading the turrets
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TurretBlueprintV2 
{
    public GameObject prefab;
    int cost;

    public GameObject upgradedPrefab;
    int upgradeCost;

    int sellAmount;

    public int Cost { get { return this.cost; } set { this.cost = value; } }
    public int UpgradeCost { get { return this.upgradeCost; } set { this.upgradeCost = value; } }
    public int SellAmount { get { return this.sellAmount; } set { this.sellAmount = value; } }
}
