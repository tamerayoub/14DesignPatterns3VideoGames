// Created by Qusai Fannoun on 15/04/2023
// this is the power up class


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PowerUp", menuName = "PowerUp")]
public class PowerUp : ScriptableObject, IVisitor
{
    public string powerUpName;
    public string powerUpDescription;

    public bool isReset = false;

    [Range(0.0f, 25f)]
    [Tooltip("Boost turret attack range settings")]
    public int turretAttackRange;


    public void Visit(Turret aTurret)
    {
        if (!isReset)
        {
            aTurret.range += turretAttackRange;
        }
        else
        {
            aTurret.range = aTurret.DefaultRange;
        }
    }
}


