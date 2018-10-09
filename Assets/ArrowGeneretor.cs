using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class ArrowGeneretor : MonoBehaviour {
	public GameObject sphere;
	private float span = 1.0f;
	private float delta = 0;

	
	// Update is called once per frame
	void Update () {
		this.delta += Time.deltaTime;
		if (this.delta > this.span) {
			this.delta = 0;
			GameObject go = Instantiate(sphere) as GameObject;
			int px = Random.Range(-2, 2);
			go.transform.position = new Vector3(px, 5, 0);
		}
	}
}
