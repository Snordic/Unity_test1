using UnityEngine;
using System.Collections;

public class UIHelper : MonoBehaviour {

	// Use this for initialization
	public void RestartButton() 
	{
	 Application.LoadLevel("lesson7");
	}
	
	// Update is called once per frame
	public void ExitButton () {
	Application.Quit();
	}
}
