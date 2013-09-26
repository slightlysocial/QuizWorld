using UnityEngine;
using System.Collections;


public class AnswerBoxPrefabClass : MonoBehaviour 
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
				//Debug.DrawLine(ray.origin, hit.point);
		
				if(Mathf.Abs(ray.origin.x-this.transform.position.x)<=1
					&& Mathf.Abs(ray.origin.y-this.transform.position.y)<=1)
				{
					//Debug.Log("i am answerbox:: boxValue is "+boxValue
					//	+" boxNumber is "+boxNumber);
					Picture_1_1_sky.redBoxNumber_current=boxNumber;
					Picture_1_1_sky.redBox_x=this.transform.position.x;
					Picture_1_1_sky.redBox_y=this.transform.position.y;
					Picture_1_1_sky.redBox_z=this.transform.position.z;
	
				}
				else
				{
				}
			}	
		}
	}
}
