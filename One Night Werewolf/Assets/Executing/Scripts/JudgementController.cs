using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JudgementController : MonoBehaviour {

	public GameObject VotingUI;
	public GameObject JudgementUI;
	public Button JudgementButton;

	void Start () 
	{
		VotingUI.SetActive (true);
		JudgementUI.SetActive (false);
		JudgementButton.onClick.AddListener (CommitJudgement);
		
	}
	

	void Update () {
		
	}

	void CommitJudgement ()
	{
		VotingUI.SetActive (false);
		JudgementUI.SetActive(true);
		Invoke ("LoadScene", 1.0f);

	}

	void LoadScene () 
	{
		SceneManager.LoadScene ("Result");
	}

}
