using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleButtonController : MonoBehaviour {

	public Button BacktoTitleButton;

	void Start () 
	{
		BacktoTitleButton.onClick.AddListener (LoadScene);
		
	}
	

	void Update () {
		
	}

	void LoadScene () 
	{
		SceneManager.LoadScene ("Title");
	}
}
