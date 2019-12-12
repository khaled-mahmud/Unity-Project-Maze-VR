using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class maze : MonoBehaviour {
	public float speed;
	public GameObject CharacterController;
	CharacterController cc;

	public int coinValue;
	private int coinCount;

	public Text scoreText;

	public Text TimerText;

	public float TotalTime;
	//private float fixedTime;
	private int timeCount;

	public int winScore;

	private bool endpoint;


	// Use this for initialization
	void Start () {
		coinCount = 0;

		endpoint = false;

		cc = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");
		Vector3 direction = new Vector3 (h, 0, v);
		Vector3 velocity = direction * speed;
		velocity = Camera.main.transform.TransformDirection (velocity);
		cc.Move (velocity * Time.deltaTime);

		TotalTime = TotalTime - Time.deltaTime;

		timeCount = (int)TotalTime;

		TimerText.text = "Time Left: " + timeCount + "s";

		if (timeCount <= 0 || endpoint==true ) {
			if (coinCount >= winScore && endpoint==true) {

				SceneManager.LoadScene ("win");
			}
			else
				SceneManager.LoadScene ("GameOver");
			
		}

		/*if (timeCount == 0 && coinCount >= winScore) {

			SceneManager.LoadScene ("win");
		}

		else if(timeCount == 0 && coinCount < winScore)
		{
			SceneManager.LoadScene ("GameOver");
		}*/


	}


	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Coin") {

			Destroy (other.gameObject);

			coinCount = coinValue + coinCount;

			scoreText.text = "Score:" + coinCount;
		}


		if(other.gameObject.tag== "endPoint")
		{

			endpoint = true;
		}

		if(other.gameObject.tag =="enemy")
		{
			Destroy (other.gameObject);
			coinCount = coinCount-coinValue;

			scoreText.text = "Score:" + coinCount;
		}


	}

}
