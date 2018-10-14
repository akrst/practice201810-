using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightColorChange : MonoBehaviour {
	public Light light;

	// Use this for initialization
	void Start () {
		if (light == null) {
			light = GameObject.Find("Directional Light").GetComponent<Light>();
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		Color c = light.color;
		if (Input.GetKey(KeyCode.RightArrow)) {
			c.r += 0.01f;
			if (c.r > 1.0f) {
				c.r = 1.0f;
			}
			light.color = c;
		}

		if (Input.GetKey(KeyCode.LeftArrow)) {
			c.r -= 0.01f;
			if (c.r < 0.0f) {
				c.r = 0.0f;
			}
			light.color = c;
		}
	}
}
