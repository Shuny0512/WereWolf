using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LectsecondController : MonoBehaviour 
{

	public float leftsecond;
	public Text leftsecondText;
	public Button IncreaseButton;
	public Button DecreaseButton;

	void Start () 
	{
		leftsecond = 60;
		leftsecondText.text = this.leftsecond.ToString ("F0");
		IncreaseButton.onClick.AddListener (MoreTime);
		DecreaseButton.onClick.AddListener (LessTime);
	}
	

	void Update () 
	{
		this.leftsecond -= Time.deltaTime;
		leftsecondText.text = this.leftsecond.ToString ("F0");
		if (leftsecond <= 0) 
		{
			this.leftsecond = 0;
		}
			
	}

	void MoreTime () 
	{
		leftsecond = this.leftsecond + 60;
		leftsecondText.text = this.leftsecond.ToString ("F0");

	}

	void LessTime ()
	{
		leftsecond = this.leftsecond - 60;
		leftsecondText.text = this.leftsecond.ToString ("F0");

	}
}
