using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchController : MonoBehaviour 
{

	public GameObject OpenUI;
	public GameObject ResultUI;
	public Button OpenButton;
	public Button CompleteButton;

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
		OpenUI.SetActive (true);
		ResultUI.SetActive (false);
	}




}
