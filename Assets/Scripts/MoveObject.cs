using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {

	public GameObject MmoveObject;
	public Transform targetPosition;
	public float Speed;



	void Start () {

	}


	void Update () 
	{   
		if (Input.GetKey (KeyCode.Space)) {
			if (Vector3.Distance (MmoveObject.transform.position, targetPosition.position) < 0.5f) {
				Destroy (MmoveObject, 2);
			} else {
				MmoveObject.transform.position = Vector3.MoveTowards (
					MmoveObject.transform.position, 
					targetPosition.position, 
					Time.deltaTime * Speed);
				MmoveObject.transform.LookAt (targetPosition);
			}
		}
    }

}