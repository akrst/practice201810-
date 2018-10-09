using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textureRandomScale : MonoBehaviour {
	private Renderer renderer;	
	private float x;
	private float y;
	
	// Use this for initialization
	void Start () {
		renderer = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		x = Random.Range(1, 5);
		y = Random.Range(1, 5);
		renderer.material.mainTextureScale = new Vector2(x, y);
	}
}
