﻿using UnityEngine;
public class AS_rotation : MonoBehaviour {

	public Vector3 Speed;
	void Start () {
	
	}
	void Update () {
		this.transform.Rotate(Speed);
	}
}
