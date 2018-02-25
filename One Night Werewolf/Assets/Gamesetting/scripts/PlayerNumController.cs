using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerNumController : MonoBehaviour 
{

	public static int  numPlayer;
	public Text textNumPlayer;
	public Button plus;
	public Button minus;

	void Start () 
	{
		numPlayer = 4;
		textNumPlayer.text = PlayerNumController.numPlayer.ToString ("F0");
		plus.onClick.AddListener (Add);
		minus.onClick.AddListener (Substruct);
		
	}


	void Update () 
	{
		
	}

	void Add () 
	{

		if (numPlayer != 6) 
		{
			PlayerNumController.numPlayer += 1;
			textNumPlayer.text = PlayerNumController.numPlayer.ToString ("F0");
			Debug.Log (PlayerNumController.numPlayer);
		}

	}

	void Substruct () 
	{

		if (numPlayer != 4) 
		{
			PlayerNumController.numPlayer -= 1;
			textNumPlayer.text = PlayerNumController.numPlayer.ToString ("F0");
			Debug.Log (PlayerNumController.numPlayer);
		}
	
	}
		

}



