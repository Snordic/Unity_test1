using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightEnemy : MonoBehaviour {
	public Vector3 rotation;
	public float Speed;
	public GameObject _target;
	Quaternion startRotation;

	void Start()
	{ 
		startRotation = transform.rotation;
	}

	void Update () {
		if (_target) 
		{
			transform.LookAt (_target.transform);	
		}
		else 
		{
			transform.Rotate (rotation * Time.deltaTime * Speed);
		}

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<PlayerControllers> ()) 
		{
			_target = other.gameObject;
		}	
	}

	void OnTriggerExit(Collider other)
	{
		if (other.GetComponent<PlayerControllers> ()) 
		{
			_target = null;
			transform.rotation = startRotation;
		}	
	}

	void OnTriggerStay(Collider other)
	{
		if (other.GetComponent<PlayerControllers> ()) 
		{

		}	
	}
}
