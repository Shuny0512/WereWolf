using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Titlebutton : MonoBehaviour {


	void Start () {
		
	}
	

	void Update () {
		
	}

	public void onClick () {
		SceneManager.LoadScene ("Title");
	}
}
