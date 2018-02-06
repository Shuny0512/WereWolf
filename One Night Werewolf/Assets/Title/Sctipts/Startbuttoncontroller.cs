using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Startbuttoncontroller : MonoBehaviour {

	void Start () {
		
	}
	

	void Update () {
		
	}

	public void Onclick () {
		SceneManager.LoadScene ("Gamesetting");
	}
}
