using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.Rotate(0.5f, 0.3f, 0.07f);
		Renderer renderer = GetComponent<Renderer>();
		Color c = renderer.material.color;
		if (Input.GetKey(KeyCode.RightArrow)) {
			c.r += 0.001f;
			if (c.r > 1.0f) {
				c.r = 1.0f;
			}
			c.b -= 0.001f;
			if (c.b < 0.0f) {
				c.b = 0.0f;
			}
			renderer.material.color = c;
		}

		if (Input.GetKey(KeyCode.LeftArrow)) {
			c.r -= 0.001f;
			if (c.r < 0.0f) {
				c.r = 0.0f;
			}
			c.b += 0.001f;
			if (c.b > 1.0f) {
				c.b = 1.0f;
			}
			renderer.material.color = c;			
		}
	}
}
