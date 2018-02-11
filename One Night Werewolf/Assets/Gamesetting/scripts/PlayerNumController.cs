using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerNumController : MonoBehaviour {

	public int numPlayer;
	public Text textNumPlayer;
	public Button plus;
	public Button minus;

	void Start () {
		numPlayer = 4;
		textNumPlayer.text = this.numPlayer.ToString ("F0");
		plus.onClick.AddListener (Add);
		minus.onClick.AddListener (Substruct);
		
	}


	void Update () {
		
	}

	void Add () {

		if (numPlayer != 8) {
			this.numPlayer += 1;
			textNumPlayer.text = this.numPlayer.ToString ("F0");
		}

	}

	void Substruct () {

		if (numPlayer != 3) {
			this.numPlayer -= 1;
			textNumPlayer.text = this.numPlayer.ToString ("F0");
		}
	
	}
		

}



