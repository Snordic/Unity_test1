using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

	public Transform target;
	public Transform rightPlane;
	public Transform leftPlane;
	public Vector3 moveLeftVector;
	public Vector3 moveRightVector;
	public float Speed;


	void Start () {
		
	}
	

	void Update () {
		Vector3 movePos = new Vector3 (target.position.x, 0.5f, -8f);
		if (Input.GetKey (KeyCode.A))
			{
			if (target.transform.position.x > (leftPlane.transform.position.x + 1.0f)) 	
				{
					target.transform.Translate (moveLeftVector * Time.deltaTime * Speed);
				}
			}
		if (Input.GetKey (KeyCode.D)) 
			{
			if (target.transform.position.x < (rightPlane.transform.position.x - 1.0f)) 
				{
					target.transform.Translate (moveRightVector * Time.deltaTime * Speed);
				}
			}
		transform.LookAt (target);
		transform.position = Vector3.MoveTowards(transform.position,movePos,Time.deltaTime*(Speed-0.5f));
	}
}
