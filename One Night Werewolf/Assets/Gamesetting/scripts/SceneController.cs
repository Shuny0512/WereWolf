using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour 
{
	public Button TitleButton;
	public Button StartButton;

	void Start () 
	{
		TitleButton.onClick.AddListener (LoadTitle);
		StartButton.onClick.AddListener(LoadNightAction);
	}
	

	void Update () 
	{
		
	}

	void LoadTitle ()
	{
		SceneManager.LoadScene ("Title");
	}

	void LoadNightAction()
	{
		SceneManager.LoadScene ("NightAction");
		Debug.Log (PlayerNumController.numPlayer);
	}
}
