using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	public GameObject BlockPrefab;
	public float SpawnTime;

	// Use this for initialization
	void Start () {
		
		InvokeRepeating ("SpawnBlock", 0, SpawnTime);

	}
	
	// Update is called once per frame
	void SpawnBlock () {
		
		GameObject block = Instantiate (BlockPrefab, transform.position, transform.rotation) as GameObject;	

	}
}
