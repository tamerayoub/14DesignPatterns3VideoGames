using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This script is our controller for the for the command pattern, this displays our view according to what command we press
public class CameraController2 : MonoBehaviour
{
    public float panSpeed = 30f;
	public float panBorderThickness = 10f;

	public float scrollSpeed = 5f;
	public float minY = 10f;
	public float maxY = 80f;


    // these functions creates the effect for each button when pressed
    public void MoveForward() {
        transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
    }

    public void MoveBackward() {
        transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
    }

    public void MoveLeft() {
        transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
    }

    public void MoveRight() {
		transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
    }

    public void Zoom() {
        float scroll = Input.GetAxis("Mouse ScrollWheel");

		Vector3 pos = transform.position;

		pos.y -= scroll * 1000 * scrollSpeed * Time.deltaTime;
		pos.y = Mathf.Clamp(pos.y, minY, maxY);

		transform.position = pos;
        
    }

	// Update is called once per frame
	void Update () {

		if (GameManager.GameIsOver)
		{
			this.enabled = false;
			return;
		}

	}
}
