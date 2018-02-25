using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VillagerNumController : MonoBehaviour {

	public float villagerNum;
	public Text villagerNumText;

	void Start () {
		/*if (PlayerNumController.numPlayer == 4) 
		{
			villagerNum = 1;
			villagerNumText.text = this.villagerNum.ToString ("F0");
		}

		if (PlayerNumController.numPlayer == 5) 
		{
			villagerNum = 1;
			villagerNumText.text = this.villagerNum.ToString ("F0");
		}*/

		villagerNum = PlayerNumController.numPlayer - 3;
		villagerNumText.text = this.villagerNum.ToString ("F0");
			
	}
	

	void Update () {
		
	}
}
