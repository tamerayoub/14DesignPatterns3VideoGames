using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 

public class InputHandler : MonoBehaviour
{
    private Invoker invoker;
    private CameraController2 cameraController;
    private Command buttonA, buttonD, buttonW, buttonS, scrollWheel;

    public float panSpeed = 30f;
	public float panBorderThickness = 10f;


    void Start()
    {
        this.invoker = gameObject.AddComponent<Invoker>();
        this.cameraController = FindObjectOfType<CameraController2>();

        this.buttonA = new MoveLeft(cameraController);
        this.buttonD = new MoveRight(cameraController);
        this.buttonW = new MoveForward(cameraController);
        this.buttonS = new MoveBackward(cameraController);
        this.scrollWheel = new Zoom(cameraController);
    }

    // This just checks to make sure our dimensions are okay before calling the 
    // invoker to execute our commands using the button methods in their invidual files 
    void Update()
    {

        if(Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
		{
             invoker.ExecuteCommand(buttonW);
		}
		if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
		{
			invoker.ExecuteCommand(buttonS);
		}
		if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
		{
			 invoker.ExecuteCommand(buttonD);
		}
		if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
		{
			 invoker.ExecuteCommand(buttonA);
		} 
       
            invoker.ExecuteCommand(scrollWheel);
        
    }

}
