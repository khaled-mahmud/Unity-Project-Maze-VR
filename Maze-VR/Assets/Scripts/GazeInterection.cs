using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GazeInterection : MonoBehaviour {

	public float pointerTime = 2f;
	private float timer = 0f;
	private bool pointerEnter;
	public string sceneName="";

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

		if (pointerEnter)
		{
			timer += Time.deltaTime;

			if (timer >= pointerTime)
			{
				// execute pointerdown handler
				ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
				SceneManager.LoadScene(sceneName);
				timer = 0f;
			}
		}

	}

	public void PointerEnter()
	{
		pointerEnter = true;

	}

	public void PointerExit()
	{
		pointerEnter = false;

	}

	public void PointerDown()
	{
		
	}
}
