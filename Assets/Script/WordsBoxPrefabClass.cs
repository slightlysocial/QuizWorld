using UnityEngine;
using System.Collections;

public class WordsBoxPrefabClass : MonoBehaviour 
{
	public int boxValue;
	public int boxNumber;
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.anyKeyDown)
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        	RaycastHit hit;
        	if (Physics.Raycast(ray, out hit, 100))
			{
				Debug.DrawLine(ray.origin, hit.point);
				
				if(Mathf.Abs(ray.origin.x-this.transform.position.x)<=1
					&& Mathf.Abs(ray.origin.y-this.transform.position.y)<=1)
				{
					if((boxNumber>0)&&(Picture_1_1_sky.wordsLetter_isAvailableChosen[boxNumber]==true))
					{
						//Debug.Log("i am wordsbox: boxValue is "+boxValue
						//+" boxNumber is "+boxNumber);
						
						Picture_1_1_sky.redBox_update=true;
						Picture_1_1_sky.redBox_value=boxValue;
						
						Picture_1_1_sky.wordsLetter_isAvailableChosen[boxNumber]=false;
						Picture_1_1_sky.wordsLetter_isAvailableChosen[Picture_1_1_sky.answerBox_wordsBoxNumber[Picture_1_1_sky.redBoxNumber_current]]=true;		
						Picture_1_1_sky.answerBox_wordsBoxNumber[Picture_1_1_sky.redBoxNumber_current]=boxNumber;
						
	
					}
				}
			}	
		}
	}
}
