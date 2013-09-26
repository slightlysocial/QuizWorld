using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	
	void OnGUI() 
	{
		GUIStyle style = new GUIStyle();
		style.fontSize = 40;
		GUI.Label(new Rect(60,90,100,40), "Score:"+GameBackground.score );	
	}
	
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
