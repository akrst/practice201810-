using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offSet : MonoBehaviour {
	public GameObject targetObject;
	public GameObject OffsetObject;
	public float offsetY;
	public float offsetZ;
	
	void Update () {
		TrackingPos();
	}
	
	[ContextMenu("TrackingPos")]
	void TrackingPos() {
		Vector3 pos = targetObject.transform.position;
		pos.y += offsetY;
		pos.z -= offsetZ;
		OffsetObject.transform.position = pos;
	}
}
