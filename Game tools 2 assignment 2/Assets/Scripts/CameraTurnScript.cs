using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTurnScript : MonoBehaviour {

    public float speedY = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

	void Start () {
		
	}
	
	public void Update () {
        if (Input.GetKey(KeyCode.LeftAlt))
        {

            yaw += speedY * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

        }
	}
}
