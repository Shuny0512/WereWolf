using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StartDiscussionButtonController : MonoBehaviour 
{
	public  Button DiscussionStartButton;

	void Start () 
	{
		DiscussionStartButton.onClick.AddListener (LoadScene);
		
	}
	

	void Update () {
		
	}

	void LoadScene ()
	{
		SceneManager.LoadScene ("Discussing");
	}
}
