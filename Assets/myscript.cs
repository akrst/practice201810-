using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject cube = GameObject.Find("Cube");
		cube.GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		GameObject cube = GameObject.Find("Cube");
		Rigidbody rigidbody = GetComponent<Rigidbody>();

		try {
			cube.transform.Rotate(1f, -1f, -1f);
		}
		catch(System.NullReferenceException e){}

		if (Input.GetKey(KeyCode.LeftArrow)) {
			rigidbody.AddForce(new Vector3(-1f, 0, 1f));
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			rigidbody.AddForce(new Vector3(1f, 0, -1f));
		}
		if (Input.GetKey(KeyCode.UpArrow)) {
			rigidbody.AddForce(new Vector3(1f, 0, 1f));
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			rigidbody.AddForce(new Vector3(-1f, 0, -1f));
		}
	}

	void OnTriggerEnter(Collider collider) {
		if (collider.gameObject.tag== "Player") {
			collider.gameObject.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 0.5f);
		}
	}

	void OnTriggerStay(Collider collider) {
		
	}

	void OnTriggerExit(Collider collider) {
		if (collider.gameObject.tag == "Player") {
			collider.gameObject.GetComponent<Renderer>().material.color = new Color(1, 0, 0, 0.5f);			
		}
	}
}