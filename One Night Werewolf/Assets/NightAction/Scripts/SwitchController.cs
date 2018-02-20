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
	public int counterMax = PlayerNumController.numPlayer;


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

		if (counter < counterMax) 
		{
			OpenUI.SetActive (true);
			ResultUI.SetActive (false);
			Debug.Log (this.counter);
			Debug.Log (this.counterMax);


		} else 
			
		{
			Debug.Log ("finish");
			Debug.Log (this.counterMax);
			SceneManager.LoadScene ("DiscussionTime");


		}
			
			



	}




}
