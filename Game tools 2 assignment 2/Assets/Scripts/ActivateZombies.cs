using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateZombies : MonoBehaviour {

    public GameObject myObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            myObject.SetActive(true);
        }
    }
}
