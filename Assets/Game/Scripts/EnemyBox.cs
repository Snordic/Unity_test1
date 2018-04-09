using UnityEngine;
using System.Collections;

public class EnemyBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter(Collider boxCollider)
	{
		if(boxCollider.name == "Car")
		{
			Application.LoadLevel("lesson7_0");
		}
	}
}
