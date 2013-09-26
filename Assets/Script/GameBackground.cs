using UnityEngine;
using System.Collections;

public class GameBackground : MonoBehaviour 
{
	public static int score = 0;
	private int score_previous = 0;
	public static int life = 5;
	
	private GameObject gamePicture;
	
	public GameObject Picture_1_1;
	public GameObject Picture_1_2;
	public GameObject Picture_1_3;
	public GameObject Picture_1_4;
	public GameObject Picture_1_5;
	public GameObject Picture_1_6;
	public GameObject Picture_1_7;
	
	string pictureName;
	
	// Use this for initialization
	void Start () 
	{
		//pictureName = Type.GetType("Picture_1_1");
	
		pictureName ="Picture_1_1";
		gamePicture = (GameObject)Instantiate(Picture_1_1);
		gamePicture.transform.position = new Vector3( 0, 4, 0 );
	}
	
	void OnGUI() 
	{
		GUIStyle style1 = new GUIStyle();
		style1.fontSize = 20;
		GUI.Label(new Rect(Screen.width/10,Screen.height/30,80,30), "Score:"+score );	
		
		GUIStyle style = new GUIStyle();
		style.fontSize = 20;
		GUI.Label(new Rect(Screen.width*7/10,Screen.height/30,80,30), "Life:"+life );	
	}
	
	void goToNextPicture ()
	{
		
		Destroy(Picture_1_1_sky.redBox);
		Destroy(Picture_1_1_sky.buttonConfirm);
		
		for(int i=0;i<20;i++)
		{
			Destroy(Picture_1_1_sky.answerBox[i]);
			Destroy(Picture_1_1_sky.answerBox_picture[i]);
			Destroy(Picture_1_1_sky.wordsLetter[i]);
		}
		
		
		switch(pictureName)
		{
			case "Picture_1_1":
	
				Destroy(gamePicture);
			
				gamePicture = (GameObject)Instantiate(Picture_1_2);
				gamePicture.transform.position = new Vector3( 0, 4, 0 );
       		break;
			   
			default:
        	break;
		}

		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(life==0)
		{
			life=-1;
			Application.LoadLevel("gameOver");
			
			
		}
		
		if(score>score_previous)
		{
			score_previous=score;
			goToNextPicture();
		}
	}
}
