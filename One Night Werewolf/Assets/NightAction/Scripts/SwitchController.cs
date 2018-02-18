using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwitchController : MonoBehaviour 
{

	public GameObject OpenUI;
	public GameObject ResultUI;
	public Button OpenButton;
	public Button CompleteButton;
	public int counter = 0;
	//public int counterMax = 5;


	void Start () 
	{
		
		OpenUI.SetActive (true);
		ResultUI.SetActive (false);
		OpenButton.onClick.AddListener (Switch);
		CompleteButton.onClick.AddListener (SwitchBack);
		
	}
	

	void Update () {
		
	}

	void Switch () 
	{
		OpenUI.SetActive (false);
		ResultUI.SetActive (true);
	}

	void SwitchBack ()
	{
		counter++;

		if (counter < 3) 
		{
			OpenUI.SetActive (true);
			ResultUI.SetActive (false);
			Debug.Log (this.counter);

		} else 
			
		{
			Debug.Log ("finish");
			SceneManager.LoadScene ("DiscussionTime");

		}
			
			



	}




}
