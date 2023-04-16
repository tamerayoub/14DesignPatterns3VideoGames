// Created by Qusai Fannoun on 15/04/2023
// this is the Interface for the TurretBlueprintV2

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITurretElement 
{
        void Accept(IVisitor visitor);
}
