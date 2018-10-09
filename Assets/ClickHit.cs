using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class ClickHit : MonoBehaviour {
	private Vector3 stdSize;
	private Vector3 smlSize;
	private RaycastHit hit;
	private int counter = 0;
	private bool flg = false;
		
	// Use this for initialization
	void Start () {
		stdSize = new Vector3(1f, 1f, 1f);
		smlSize = new Vector3(0.5f, 0.5f, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		if (flg) {
			if (counter <= 0) {
				hit.transform.localScale = stdSize;
				flg = false;
			}
			else {
				counter--;
			}
		}

		if (Input.GetMouseButton(0)) {
			Vector3 pos = Input.mousePosition;
			pos.z = 3.0f;
			Ray ray = Camera.main.ScreenPointToRay(pos);
			if (!flg) {
				if (Physics.Raycast(ray, out hit, 100)) {
					hit.transform.localScale = smlSize;
					counter = 100;
					flg = true;
				}
				else {
					Vector3 newpos = Camera.main.ScreenToWorldPoint(pos);
					transform.position = newpos;
				}
			}
		}
	}
}
