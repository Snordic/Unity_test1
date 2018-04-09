using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyController : MonoBehaviour {
	 Animator animController;



	// Use this for initialization
	void Start () {
		animController = GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			animController.SetBool ("idleBool", true);
		} else if (Input.GetMouseButtonDown (1)) {
			animController.SetBool ("idleBool", false);
		} else if (Input.GetKeyDown (KeyCode.Space)) {
			animController.SetInteger ("intLife", 0);
		}

	}
}
