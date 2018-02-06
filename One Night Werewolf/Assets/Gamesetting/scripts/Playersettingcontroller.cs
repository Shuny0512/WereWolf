using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playersettingcontroller : MonoBehaviour {

	GameObject player;
	public int players;


	void Start () {
		this.player = GameObject.Find ("Howmanyplayers");
		players = 4;
		this.player.GetComponent<Text> ().text =
			this.players.ToString ("F0");
	}


	void Update () {
		
	}
		

}



