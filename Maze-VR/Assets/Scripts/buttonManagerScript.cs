using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonManagerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onTriggerRestart(){
		Debug.Log ("hello");
		SceneManager.LoadScene ("1");
		//SceneManager.LoadScene ("GameOver");

	}

	public void onTriggerHome(){
		Debug.Log ("hello");
		SceneManager.LoadScene ("home");
		//SceneManager.LoadScene ("GameOver");

	}



}
