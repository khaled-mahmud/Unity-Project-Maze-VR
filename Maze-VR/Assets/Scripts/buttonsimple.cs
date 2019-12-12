using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonsimple : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator ontrigge()
	{
		yield return new WaitForSeconds(10f);
		//SceneManager.LoadScene ("1");

		Debug.Log ("wait");
	}




	public void ontri()
	{
		StartCoroutine ("ontrigge");
		//ontrigge ();
		SceneManager.LoadScene ("1");

	}

		
	
}
