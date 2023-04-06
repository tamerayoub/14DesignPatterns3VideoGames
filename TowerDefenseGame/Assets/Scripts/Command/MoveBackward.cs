using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This executes the command linked with the command pattern and the controller
public class MoveBackward : Command
{
   private CameraController2 controller;

    public MoveBackward(CameraController2 aController) {
        this.controller = aController;
    }

    public override void Execute() {
        this.controller.MoveBackward();
    }
}
