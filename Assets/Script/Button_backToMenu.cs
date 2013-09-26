using UnityEngine;
using System.Collections;

public class Button_backToMenu : MonoBehaviour 
{

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
		
				if(Mathf.Abs(ray.origin.x-this.transform.position.x)<=1.3
					&& Mathf.Abs(ray.origin.y-this.transform.position.y)<=1.3)
				{
					Application.LoadLevel("menuScene");
				}
				else
				{
				}
			}	
		}
	
	}
}
