using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlocks : MonoBehaviour {


	public float Speed;



	void Start () {
		Destroy (gameObject, 10);
	}


	void Update () 
	{
			//transform.position = Vector3.MoveTowards (
			//	transform.position, 
			//	targetPosition.position, 
			//	Time.deltaTime * Speed);
		transform.Translate(Vector3.forward*Time.deltaTime*Speed);
		}
	}

