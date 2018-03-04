using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DiscussingButtonController : MonoBehaviour {

	public Button FinishdiscussionButton;

	void Start () 
	{
		FinishdiscussionButton.onClick.AddListener (LoadScene);
	}


	void Update () {
		
	}

	void LoadScene ()
	{
		SceneManager.LoadScene ("Executing");
	}
}
