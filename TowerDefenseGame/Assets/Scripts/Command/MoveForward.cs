using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This executes the command linked with the command pattern and the controller
public class MoveForward : Command
{
   private CameraController2 controller;

    public MoveForward(CameraController2 aController) {
        this.controller = aController;
    }


    public override void Execute() {

        this.controller.MoveForward();
    }
}
