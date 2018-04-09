using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject_1 : MonoBehaviour {
	public Vector3 moveVector;
	public float Speed;
	public float TimeBeforeDestoty;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, TimeBeforeDestoty);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (moveVector * Time.deltaTime * Speed);
	}
}
