using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class chanegStandardShaderRenderingMode : MonoBehaviour {
	private int counter = 0;
	private GameObject obj = null;
	
	
	// Use this for initialization
	void Start () {
		GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");
		foreach (GameObject obj in objs) {
			Renderer render = obj.GetComponent<Renderer>();
			render.material.SetFloat("_Mode", 3f);
			render.material.SetInt("_SrcBlend", (int)BlendMode.SrcAlpha);
			render.material.SetInt("_DstBlend", (int)BlendMode.OneMinusSrcAlpha);
			render.material.SetInt("_ZWrite", 0);
			render.material.DisableKeyword("_ALPHATEST_ON");
			render.material.EnableKeyword("_ALPHABLEND_ON");
			render.material.DisableKeyword("_ALPHAPREMULTIPLY_ON");
			render.material.renderQueue = 3000;
		}
	}

	private void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Player") {
			Renderer renderer = collision.gameObject.GetComponent<Renderer>();
			Color color = renderer.material.color;
			color.a = 0.25f;
			renderer.material.color = color;
		}
	}

	private void OnTriggerExit(Collider collision) {
		if (collision.gameObject.tag == "Player") {
			Renderer renderer = collision.gameObject.GetComponent<Renderer>();
			Color color = renderer.material.color;
			color.a = 1.0f;
			renderer.material.color = color;
		}
	}
}
