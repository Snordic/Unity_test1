using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public GameObject Car;

	// Use this for initialization
	void Start () {
		Car = GameObject.Find ("Car");
	}
	
	// Update is called once per frame
	void Update () {
		if (Car != null && Vector3.Distance (Car.transform.position, transform.position) < 0.8f) 
		{
			Destroy (Car);
			Application.LoadLevel ("lesson3_2");
		}
		
	}
}
