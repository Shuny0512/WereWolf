using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerNumController : MonoBehaviour {

	GameObject player;
	public int players;
	public Button plus;
	public Button minus;

	void Start () {
		this.player = GameObject.Find ("howmanyplayers");
		players = 4;
		this.player.GetComponent<Text> ().text =
			this.players.ToString ("F0");

		plus.onClick.AddListener (Add);
		minus.onClick.AddListener (Substruct);
	}


	void Update () {
		
	}

	void Add () {
		players++;
	}

	void Substruct () {
		players--;
	}
		

}



