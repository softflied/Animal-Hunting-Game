﻿using UnityEngine;
public class AS_RagdollReplace : MonoBehaviour {

	public GameObject LootAtObject;

	void Start () {
		if(LootAtObject == null){
			LootAtObject = this.transform.root.gameObject;	
		}
	}
}
