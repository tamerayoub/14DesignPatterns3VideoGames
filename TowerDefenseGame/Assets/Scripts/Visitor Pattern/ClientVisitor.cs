// Created by Qusai Fannoun on 15/04/2023
// this is the client visitor class

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientVisitor : MonoBehaviour
{
    public PowerUp attackRangePowerUp;
    public PowerUp resetAttackRangePowerUp;

    private TurretController turretController;

    private void Start()
    {
        turretController = GameObject.FindObjectOfType<TurretController>();
    }


    private void OnGUI()
    {
        if (GUILayout.Button("Power Up Attack range"))
        {
            turretController.Accept(attackRangePowerUp);
        }

        if (GUILayout.Button("Reset Attack range"))
        {
            turretController.Accept(resetAttackRangePowerUp);
        }
    }
}

