using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class NightActionTitleButtonController : MonoBehaviour
{


	public Button TitleButton;
	void Start () 
	{
		TitleButton.onClick.AddListener (LoadScene);
	}
	

	void Update () 
	{
		
	}

	void LoadScene () 
	{
		SceneManager.LoadScene ("Title");
	}
}
