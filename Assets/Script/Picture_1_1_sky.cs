using UnityEngine;
using System.Collections;



public class Picture_1_1_sky : MonoBehaviour 
{
	public GameObject answerBoxPrefab;
	
	public GameObject LetterPrefab_a;
	public GameObject LetterPrefab_b;
	public GameObject LetterPrefab_c;
	public GameObject LetterPrefab_d;
	public GameObject LetterPrefab_e;
	public GameObject LetterPrefab_f;
	public GameObject LetterPrefab_g;
	public GameObject LetterPrefab_h;
	public GameObject LetterPrefab_i;
	public GameObject LetterPrefab_j;
	public GameObject LetterPrefab_k;
	public GameObject LetterPrefab_l;
	public GameObject LetterPrefab_m;
	public GameObject LetterPrefab_n;
	public GameObject LetterPrefab_o;
	public GameObject LetterPrefab_p;
	public GameObject LetterPrefab_q;
	public GameObject LetterPrefab_r;
	public GameObject LetterPrefab_s;
	public GameObject LetterPrefab_t;
	public GameObject LetterPrefab_u;
	public GameObject LetterPrefab_v;
	public GameObject LetterPrefab_w;
	public GameObject LetterPrefab_x;
	public GameObject LetterPrefab_y;
	public GameObject LetterPrefab_z;
	
	public GameObject buttonConfirmPrefab;
	public static GameObject buttonConfirm;
	
	public static bool answerIsCorrect;
	
	private int wordsBoxNumber;
	
	public string answer;
	
	public static GameObject[] answerBox = new GameObject[20];
	public static GameObject[] answerBox_picture = new GameObject[20];
	public static int[] answerBox_value = new int[20];//This variable is used to store the pictures for showing in answer box.
	public static int[] answerBox_wordsBoxNumber = new int[20];//This variable is used to restore the words box number which answer box's pictures come from.
	
	public static GameObject[] wordsLetter = new GameObject[20];
	public static bool[] wordsLetter_isAvailableChosen = new bool[20];
	
	public GameObject redBoxPrefab;
	public static GameObject redBox;
	public static int redBoxNumber_previous;
	public static int redBoxNumber_current;
	public static float redBox_x;
	public static float redBox_y;
	public static float redBox_z;
	
	public static int redBox_value;
	public static bool redBox_update;
	
	// Use this for initialization
	void Start () 
	{
		//Debug.Log("answer is "+answer + " lenght is "+answer.Length);
		wordsLetterCreate();
		answerBoxCreate();
		buttonCreate();
	}
	
	void buttonCreate()
	{
		buttonConfirm = (GameObject)Instantiate(buttonConfirmPrefab);
		buttonConfirm.transform.position 
				= new Vector3( 4f, -0.8f, 2f );
	}
	
	void wordsLetterCreate ()
	{
		wordsBoxNumber=8;

		int[] wordsPositionWithAnswerLetter = new int[wordsBoxNumber+1];
		
		for(int i=1; i<=wordsBoxNumber; i++)
		{
			wordsPositionWithAnswerLetter[i]=0;
		}
		
		for(int i=1; i<=answer.Length; i++)
		{
			bool continueToFind=true;
			while(continueToFind)
			{
				int randomPosition  = Random.Range(1,wordsBoxNumber+1);
				
				if(wordsPositionWithAnswerLetter[randomPosition]==0)
				{
					wordsPositionWithAnswerLetter[randomPosition]=answer[i-1];
					continueToFind=false;
				}	
			}
		}
		
		/*
		for(int i=1; i<=wordsBoxNumber; i++)
		{
			Debug.Log("wordsPositionWithAnswerLetter "+i+" is: "+wordsPositionWithAnswerLetter[i]);
		}
		*/
		
		float x=-4.5f;
		float y=-6f;
		int randomLetter;
		WordsBoxPrefabClass wordBox;
		for(int i=1; i<=wordsBoxNumber; i++)
		{
			if(i==5)
			{
				x=-4.5f;
				y=-8f;
			}
			
			randomLetter=0;
			if(wordsPositionWithAnswerLetter[i]==0)
			{
				randomLetter = Random.Range(1,27);
				//Debug.Log("randomLetter is "+randomLetter);
			}
			else if(wordsPositionWithAnswerLetter[i]!=0)
			{
				randomLetter = wordsPositionWithAnswerLetter[i]-96;
			}

			switch(randomLetter)
			{
				case 1:
					wordsLetter[i] = (GameObject)Instantiate(LetterPrefab_a);
					wordsLetter[i].transform.position = new Vector3( x, y, 2f );
				
					wordBox = (WordsBoxPrefabClass)wordsLetter[i].GetComponent("WordsBoxPrefabClass");
					wordBox.boxValue = 1;
					wordBox.boxNumber = i;
					wordsLetter_isAvailableChosen[i] = true;
       			 break;
				
				case 2:
					wordsLetter[i] = (GameObject)Instantiate(LetterPrefab_b);
					wordsLetter[i].transform.position = new Vector3( x, y, 2f );
				
					wordBox = (WordsBoxPrefabClass)wordsLetter[i].GetComponent("WordsBoxPrefabClass");
					wordBox.boxValue = 2;
					wordBox.boxNumber = i;
					wordsLetter_isAvailableChosen[i] = true;
       			 break;
				
				case 3:
					wordsLetter[i] = (GameObject)Instantiate(LetterPrefab_c);
					wordsLetter[i].transform.position = new Vector3( x, y, 2f );
				
					wordBox = (WordsBoxPrefabClass)wordsLetter[i].GetComponent("WordsBoxPrefabClass");
					wordBox.boxValue = 3;
					wordBox.boxNumber = i;
					wordsLetter_isAvailableChosen[i] = true;
       			 break;
				
				case 4:
					wordsLetter[i] = (GameObject)Instantiate(LetterPrefab_d);
					wordsLetter[i].transform.position = new Vector3( x, y, 2f );
				
					wordBox = (WordsBoxPrefabClass)wordsLetter[i].GetComponent("WordsBoxPrefabClass");
					wordBox.boxValue = 4;
					wordBox.boxNumber = i;
					wordsLetter_isAvailableChosen[i] = true;
       			 break;
				
				case 5:
					wordsLetter[i] = (GameObject)Instantiate(LetterPrefab_e);
					wordsLetter[i].transform.position = new Vector3( x, y, 2f );
				
					wordBox = (WordsBoxPrefabClass)wordsLetter[i].GetComponent("WordsBoxPrefabClass");
					wordBox.boxValue = 5;
					wordBox.boxNumber = i;
					wordsLetter_isAvailableChosen[i] = true;
       			 break;
				
				case 6:
					wordsLetter[i] = (GameObject)Instantiate(LetterPrefab_f);
					wordsLetter[i].transform.position = new Vector3( x, y, 2f );
				
					wordBox = (WordsBoxPrefabClass)wordsLetter[i].GetComponent("WordsBoxPrefabClass");
					wordBox.boxValue = 6;
					wordBox.boxNumber = i;
					wordsLetter_isAvailableChosen[i] = true;
       			 break;
				
				case 7:
					wordsLetter[i] = (GameObject)Instantiate(LetterPrefab_g);
					wordsLetter[i].transform.position = new Vector3( x, y, 2f );
				
					wordBox = (WordsBoxPrefabClass)wordsLetter[i].GetComponent("WordsBoxPrefabClass");
					wordBox.boxValue = 7;
					wordBox.boxNumber = i;
					wordsLetter_isAvailableChosen[i] = true;
       			 break;
				
				case 8:
					wordsLetter[i] = (GameObject)Instantiate(LetterPrefab_h);
					wordsLetter[i].transform.position = new Vector3( x, y, 2f );
				
					wordBox = (WordsBoxPrefabClass)wordsLetter[i].GetComponent("WordsBoxPrefabClass");
					wordBox.boxValue = 8;
					wordBox.boxNumber = i;
					wordsLetter_isAvailableChosen[i] = true;
       			 break;
				
				case 9:
					wordsLetter[i] = (GameObject)Instantiate(LetterPrefab_i);
					wordsLetter[i].transform.position = new Vector3( x, y, 2f );
				
					wordBox = (WordsBoxPrefabClass)wordsLetter[i].GetComponent("WordsBoxPrefabClass");
					wordBox.boxValue = 9;
					wordBox.boxNumber = i;
					wordsLetter_isAvailableChosen[i] = true;
       			 break;
				
				case 10:
					wordsLetter[i] = (GameObject)Instantiate(LetterPrefab_j);
					wordsLetter[i].transform.position = new Vector3( x, y, 2f );
				
					wordBox = (WordsBoxPrefabClass)wordsLetter[i].GetComponent("WordsBoxPrefabClass");
					wordBox.boxValue = 10;
					wordBox.boxNumber = i;
					wordsLetter_isAvailableChosen[i] = true;
       			 break;
				
				case 11:
					wordsLetter[i] = (GameObject)Instantiate(LetterPrefab_k);
					wordsLetter[i].transform.position = new Vector3( x, y, 2f );
				
					wordBox = (WordsBoxPrefabClass)wordsLetter[i].GetComponent("WordsBoxPrefabClass");
					wordBox.boxValue = 11;
					wordBox.boxNumber = i;
					wordsLetter_isAvailableChosen[i] = true;
       			 break;
				
				case 12:
					wordsLetter[i] = (GameObject)Instantiate(LetterPrefab_l);
					wordsLetter[i].transform.position = new Vector3( x, y, 2f );
				
					wordBox = (WordsBoxPrefabClass)wordsLetter[i].GetComponent("WordsBoxPrefabClass");
					wordBox.boxValue = 12;
					wordBox.boxNumber = i;
					wordsLetter_isAvailableChosen[i] = true;
       			 break;
				
				case 13:
					wordsLetter[i] = (GameObject)Instantiate(LetterPrefab_m);
					wordsLetter[i].transform.position = new Vector3( x, y, 2f );
				
					wordBox = (WordsBoxPrefabClass)wordsLetter[i].GetComponent("WordsBoxPrefabClass");
					wordBox.boxValue = 13;
					wordBox.boxNumber = i;
					wordsLetter_isAvailableChosen[i] = true;
       			 break;
				
				case 14:
					wordsLetter[i] = (GameObject)Instantiate(LetterPrefab_n);
					wordsLetter[i].transform.position = new Vector3( x, y, 2f );
				
					wordBox = (WordsBoxPrefabClass)wordsLetter[i].GetComponent("WordsBoxPrefabClass");
					wordBox.boxValue = 14;
					wordBox.boxNumber = i;
					wordsLetter_isAvailableChosen[i] = true;
       			 break;
				
				case 15:
					wordsLetter[i] = (GameObject)Instantiate(LetterPrefab_o);
					wordsLetter[i].transform.position = new Vector3( x, y, 2f );
					wordBox = (WordsBoxPrefabClass)wordsLetter[i].GetComponent("WordsBoxPrefabClass");
					wordBox.boxValue = 15;
					wordBox.boxNumber = i;
					wordsLetter_isAvailableChosen[i] = true;
       			 break;
				
				case 16:
					wordsLetter[i] = (GameObject)Instantiate(LetterPrefab_p);
					wordsLetter[i].transform.position = new Vector3( x, y, 2f );
				
					wordBox = (WordsBoxPrefabClass)wordsLetter[i].GetComponent("WordsBoxPrefabClass");
					wordBox.boxValue = 16;
					wordBox.boxNumber = i;
					wordsLetter_isAvailableChosen[i] = true;
       			 break;
				
				case 17:
					wordsLetter[i] = (GameObject)Instantiate(LetterPrefab_q);
					wordsLetter[i].transform.position = new Vector3( x, y, 2f );
				
					wordBox = (WordsBoxPrefabClass)wordsLetter[i].GetComponent("WordsBoxPrefabClass");
					wordBox.boxValue = 17;
					wordBox.boxNumber = i;
					wordsLetter_isAvailableChosen[i] = true;
       			 break;
				
				case 18:
					wordsLetter[i] = (GameObject)Instantiate(LetterPrefab_r);
					wordsLetter[i].transform.position = new Vector3( x, y, 2f );
				
					wordBox = (WordsBoxPrefabClass)wordsLetter[i].GetComponent("WordsBoxPrefabClass");
					wordBox.boxValue = 18;
					wordBox.boxNumber = i;
					wordsLetter_isAvailableChosen[i] = true;
       			 break;
				
				case 19:
					wordsLetter[i] = (GameObject)Instantiate(LetterPrefab_s);
					wordsLetter[i].transform.position = new Vector3( x, y, 2f );
				
					wordBox = (WordsBoxPrefabClass)wordsLetter[i].GetComponent("WordsBoxPrefabClass");
					wordBox.boxValue = 19;
					wordBox.boxNumber = i;
					wordsLetter_isAvailableChosen[i] = true;
       			 break;
				
				case 20:
					wordsLetter[i] = (GameObject)Instantiate(LetterPrefab_t);
					wordsLetter[i].transform.position = new Vector3( x, y, 2f );
				
					wordBox = (WordsBoxPrefabClass)wordsLetter[i].GetComponent("WordsBoxPrefabClass");
					wordBox.boxValue = 20;
					wordBox.boxNumber = i;
					wordsLetter_isAvailableChosen[i] = true;
       			 break;
				
				case 21:
					wordsLetter[i] = (GameObject)Instantiate(LetterPrefab_u);
					wordsLetter[i].transform.position = new Vector3( x, y, 2f );
				
					wordBox = (WordsBoxPrefabClass)wordsLetter[i].GetComponent("WordsBoxPrefabClass");
					wordBox.boxValue = 21;
					wordBox.boxNumber = i;
					wordsLetter_isAvailableChosen[i] = true;
       			 break;
				
				case 22:
					wordsLetter[i] = (GameObject)Instantiate(LetterPrefab_v);
					wordsLetter[i].transform.position = new Vector3( x, y, 2f );
				
					wordBox = (WordsBoxPrefabClass)wordsLetter[i].GetComponent("WordsBoxPrefabClass");
					wordBox.boxValue = 22;
					wordBox.boxNumber = i;
					wordsLetter_isAvailableChosen[i] = true;
       			 break;
				
				case 23:
					wordsLetter[i] = (GameObject)Instantiate(LetterPrefab_w);
					wordsLetter[i].transform.position = new Vector3( x, y, 2f );
				
					wordBox = (WordsBoxPrefabClass)wordsLetter[i].GetComponent("WordsBoxPrefabClass");
					wordBox.boxValue = 23;
					wordBox.boxNumber = i;
					wordsLetter_isAvailableChosen[i] = true;
       			 break;
				
				case 24:
					wordsLetter[i] = (GameObject)Instantiate(LetterPrefab_x);
					wordsLetter[i].transform.position = new Vector3( x, y, 2f );
				
					wordBox = (WordsBoxPrefabClass)wordsLetter[i].GetComponent("WordsBoxPrefabClass");
					wordBox.boxValue = 24;
					wordBox.boxNumber = i;
					wordsLetter_isAvailableChosen[i] = true;
       			 break;
				
				case 25:
					wordsLetter[i] = (GameObject)Instantiate(LetterPrefab_y);
					wordsLetter[i].transform.position = new Vector3( x, y, 2f );
				
					wordBox = (WordsBoxPrefabClass)wordsLetter[i].GetComponent("WordsBoxPrefabClass");
					wordBox.boxValue = 25;
					wordBox.boxNumber = i;
					wordsLetter_isAvailableChosen[i] = true;
       			 break;
				
				case 26:
					wordsLetter[i] = (GameObject)Instantiate(LetterPrefab_z);
					wordsLetter[i].transform.position = new Vector3( x, y, 2f );
				
					wordBox = (WordsBoxPrefabClass)wordsLetter[i].GetComponent("WordsBoxPrefabClass");
					wordBox.boxValue = 26;
					wordBox.boxNumber = i;
					wordsLetter_isAvailableChosen[i] = true;
       			 break;
				
   
				default:
        		break;
			}
		
			x+=3f;
		}

	}
	
	
	
	void answerBoxCreate ()
	{
		int answerBoxStartPoint=0;
		float answerBoxDistance= 2;
		
		if(answer.Length%2==1)
		{
			answerBoxStartPoint=(int)(-1*answerBoxDistance*(answer.Length-1)/2);
		}
		else if(answer.Length%2==0)
		{
			answerBoxStartPoint=(int)(-1*(1+answerBoxDistance*(answer.Length-2)/2));
		}
		
		for(int i=1; i<=answer.Length; i++)
		{			
			answerBox[i] = (GameObject)Instantiate(answerBoxPrefab);
			answerBox[i].transform.position 
				= new Vector3( answerBoxStartPoint + (i-1)*answerBoxDistance
					, -3f, 2f );
			
			AnswerBoxPrefabClass ansBox = (AnswerBoxPrefabClass)answerBox[i].GetComponent("AnswerBoxPrefabClass");
			ansBox.boxValue = i;
			ansBox.boxNumber = i;
			
			if(i==1)
			{
				//we initialize the redBox's position to the
				redBox_x=answerBox[i].transform.position.x;
				redBox_y=answerBox[i].transform.position.y;
				redBox_z=answerBox[i].transform.position.z;
			}
			
			answerBox_value[i]=0;
			answerBox_wordsBoxNumber[i]=0;
		}
		
		redBoxNumber_previous=1;
		redBoxNumber_current=1;
		redBox_update=false;
		redBox_value=0;
		redBoxCreate ();
	}
	
	void redBoxRemove ()
	{
		Destroy(redBox);
	}
	
	void redBoxCreate ()
	{	
		redBox = (GameObject)Instantiate(redBoxPrefab);
		redBox.transform.position = new Vector3( redBox_x, redBox_y, redBox_z+1);
	}
	
	void answerBoxRemove ()
	{
		Destroy(answerBox_picture[redBoxNumber_current]);
	}
	
	void answerBoxUpdate ()
	{	
		float x,y,z;
		x=answerBox[redBoxNumber_current].transform.position.x;
		y=answerBox[redBoxNumber_current].transform.position.y;
		z=answerBox[redBoxNumber_current].transform.position.z-1;
		
		AnswerBoxPrefabClass ansBox;
		switch(redBox_value)
		{	
			case 1:
				answerBox_picture[redBoxNumber_current] = (GameObject)Instantiate(LetterPrefab_a);
				answerBox_picture[redBoxNumber_current].transform.position = new Vector3( x, y, z );
				
			    ansBox = (AnswerBoxPrefabClass)answerBox[redBoxNumber_current].GetComponent("AnswerBoxPrefabClass");
				ansBox.boxValue = 1;
			
				answerBox_value[redBoxNumber_current]=97;
       		break;
				
			case 2:
				answerBox_picture[redBoxNumber_current] = (GameObject)Instantiate(LetterPrefab_b);
				answerBox_picture[redBoxNumber_current].transform.position = new Vector3( x, y, z );
				
				ansBox = (AnswerBoxPrefabClass)answerBox[redBoxNumber_current].GetComponent("AnswerBoxPrefabClass");
				ansBox.boxValue = 2;
			
				answerBox_value[redBoxNumber_current]=98;
       		break;
			
   			case 3:
				answerBox_picture[redBoxNumber_current] = (GameObject)Instantiate(LetterPrefab_c);
				answerBox_picture[redBoxNumber_current].transform.position = new Vector3( x, y, z );
				
				ansBox = (AnswerBoxPrefabClass)answerBox[redBoxNumber_current].GetComponent("AnswerBoxPrefabClass");
				ansBox.boxValue = 3;
			
				answerBox_value[redBoxNumber_current]=99;
       		break;
			
			case 4:
				answerBox_picture[redBoxNumber_current] = (GameObject)Instantiate(LetterPrefab_d);
				answerBox_picture[redBoxNumber_current].transform.position = new Vector3( x, y, z );
				
				ansBox = (AnswerBoxPrefabClass)answerBox[redBoxNumber_current].GetComponent("AnswerBoxPrefabClass");
				ansBox.boxValue = 4;
			
				answerBox_value[redBoxNumber_current]=100;
       		break;
			
			case 5:
				answerBox_picture[redBoxNumber_current] = (GameObject)Instantiate(LetterPrefab_e);
				answerBox_picture[redBoxNumber_current].transform.position = new Vector3( x, y, z );
				
				ansBox = (AnswerBoxPrefabClass)answerBox[redBoxNumber_current].GetComponent("AnswerBoxPrefabClass");
				ansBox.boxValue = 5;
			
				answerBox_value[redBoxNumber_current]=101;
       		break;
			
			case 6:
				answerBox_picture[redBoxNumber_current] = (GameObject)Instantiate(LetterPrefab_f);
				answerBox_picture[redBoxNumber_current].transform.position = new Vector3( x, y, z );
				
				ansBox = (AnswerBoxPrefabClass)answerBox[redBoxNumber_current].GetComponent("AnswerBoxPrefabClass");
				ansBox.boxValue = 6;
			
				answerBox_value[redBoxNumber_current]=102;
       		break;			
			
			case 7:
				answerBox_picture[redBoxNumber_current] = (GameObject)Instantiate(LetterPrefab_g);
				answerBox_picture[redBoxNumber_current].transform.position = new Vector3( x, y, z );
				
				ansBox = (AnswerBoxPrefabClass)answerBox[redBoxNumber_current].GetComponent("AnswerBoxPrefabClass");
				ansBox.boxValue = 7;
			
				answerBox_value[redBoxNumber_current]=103;
       		break;			
			
			case 8:
				answerBox_picture[redBoxNumber_current] = (GameObject)Instantiate(LetterPrefab_h);
				answerBox_picture[redBoxNumber_current].transform.position = new Vector3( x, y, z );
				
				ansBox = (AnswerBoxPrefabClass)answerBox[redBoxNumber_current].GetComponent("AnswerBoxPrefabClass");
				ansBox.boxValue = 8;
			
				answerBox_value[redBoxNumber_current]=104;
       		break;
			
			case 9:
				answerBox_picture[redBoxNumber_current] = (GameObject)Instantiate(LetterPrefab_i);
				answerBox_picture[redBoxNumber_current].transform.position = new Vector3( x, y, z );
				
				ansBox = (AnswerBoxPrefabClass)answerBox[redBoxNumber_current].GetComponent("AnswerBoxPrefabClass");
				ansBox.boxValue = 9;
			
				answerBox_value[redBoxNumber_current]=105;
       		break;			
			
			case 10:
				answerBox_picture[redBoxNumber_current] = (GameObject)Instantiate(LetterPrefab_j);
				answerBox_picture[redBoxNumber_current].transform.position = new Vector3( x, y, z );
				
				ansBox = (AnswerBoxPrefabClass)answerBox[redBoxNumber_current].GetComponent("AnswerBoxPrefabClass");
				ansBox.boxValue = 10;
			
				answerBox_value[redBoxNumber_current]=106;
       		break;			
			
			
			case 11:
				answerBox_picture[redBoxNumber_current] = (GameObject)Instantiate(LetterPrefab_k);
				answerBox_picture[redBoxNumber_current].transform.position = new Vector3( x, y, z );
				
				ansBox = (AnswerBoxPrefabClass)answerBox[redBoxNumber_current].GetComponent("AnswerBoxPrefabClass");
				ansBox.boxValue = 11;
			
				answerBox_value[redBoxNumber_current]=107;
       		break;			
			
			case 12:
				answerBox_picture[redBoxNumber_current] = (GameObject)Instantiate(LetterPrefab_l);
				answerBox_picture[redBoxNumber_current].transform.position = new Vector3( x, y, z );
				
				ansBox = (AnswerBoxPrefabClass)answerBox[redBoxNumber_current].GetComponent("AnswerBoxPrefabClass");
				ansBox.boxValue = 12;
			
				answerBox_value[redBoxNumber_current]=108;
       		break;
			
			case 13:
				answerBox_picture[redBoxNumber_current] = (GameObject)Instantiate(LetterPrefab_m);
				answerBox_picture[redBoxNumber_current].transform.position = new Vector3( x, y, z );
				
				ansBox = (AnswerBoxPrefabClass)answerBox[redBoxNumber_current].GetComponent("AnswerBoxPrefabClass");
				ansBox.boxValue = 13;
			
				answerBox_value[redBoxNumber_current]=109;
       		break;
			
			case 14:
				answerBox_picture[redBoxNumber_current] = (GameObject)Instantiate(LetterPrefab_n);
				answerBox_picture[redBoxNumber_current].transform.position = new Vector3( x, y, z );
				
				ansBox = (AnswerBoxPrefabClass)answerBox[redBoxNumber_current].GetComponent("AnswerBoxPrefabClass");
				ansBox.boxValue = 14;
			
				answerBox_value[redBoxNumber_current]=110;
       		break;
			
			case 15:
				answerBox_picture[redBoxNumber_current] = (GameObject)Instantiate(LetterPrefab_o);
				answerBox_picture[redBoxNumber_current].transform.position = new Vector3( x, y, z );
				
				ansBox = (AnswerBoxPrefabClass)answerBox[redBoxNumber_current].GetComponent("AnswerBoxPrefabClass");
				ansBox.boxValue = 15;
			
				answerBox_value[redBoxNumber_current]=111;
       		break;
			
			case 16:
				answerBox_picture[redBoxNumber_current] = (GameObject)Instantiate(LetterPrefab_p);
				answerBox_picture[redBoxNumber_current].transform.position = new Vector3( x, y, z );
				
				ansBox = (AnswerBoxPrefabClass)answerBox[redBoxNumber_current].GetComponent("AnswerBoxPrefabClass");
				ansBox.boxValue = 16;
			
				answerBox_value[redBoxNumber_current]=112;
       		break;
			
			case 17:
				answerBox_picture[redBoxNumber_current] = (GameObject)Instantiate(LetterPrefab_q);
				answerBox_picture[redBoxNumber_current].transform.position = new Vector3( x, y, z );
				
				ansBox = (AnswerBoxPrefabClass)answerBox[redBoxNumber_current].GetComponent("AnswerBoxPrefabClass");
				ansBox.boxValue = 17;
			
				answerBox_value[redBoxNumber_current]=113;
       		break;
			
			
			case 18:
				answerBox_picture[redBoxNumber_current] = (GameObject)Instantiate(LetterPrefab_r);
				answerBox_picture[redBoxNumber_current].transform.position = new Vector3( x, y, z );
				
				ansBox = (AnswerBoxPrefabClass)answerBox[redBoxNumber_current].GetComponent("AnswerBoxPrefabClass");
				ansBox.boxValue = 18;
			
				answerBox_value[redBoxNumber_current]=114;
       		break;
			
			case 19:
				answerBox_picture[redBoxNumber_current] = (GameObject)Instantiate(LetterPrefab_s);
				answerBox_picture[redBoxNumber_current].transform.position = new Vector3( x, y, z );
				
				ansBox = (AnswerBoxPrefabClass)answerBox[redBoxNumber_current].GetComponent("AnswerBoxPrefabClass");
				ansBox.boxValue = 19;
			
				answerBox_value[redBoxNumber_current]=115;
       		break;
			
			case 20:
				answerBox_picture[redBoxNumber_current] = (GameObject)Instantiate(LetterPrefab_t);
				answerBox_picture[redBoxNumber_current].transform.position = new Vector3( x, y, z );
				
				ansBox = (AnswerBoxPrefabClass)answerBox[redBoxNumber_current].GetComponent("AnswerBoxPrefabClass");
				ansBox.boxValue = 20;
			
				answerBox_value[redBoxNumber_current]=116;
       		break;
			
			case 21:
				answerBox_picture[redBoxNumber_current] = (GameObject)Instantiate(LetterPrefab_u);
				answerBox_picture[redBoxNumber_current].transform.position = new Vector3( x, y, z );
				
				ansBox = (AnswerBoxPrefabClass)answerBox[redBoxNumber_current].GetComponent("AnswerBoxPrefabClass");
				ansBox.boxValue = 21;
			
				answerBox_value[redBoxNumber_current]=117;
       		break;
			
			case 22:
				answerBox_picture[redBoxNumber_current] = (GameObject)Instantiate(LetterPrefab_v);
				answerBox_picture[redBoxNumber_current].transform.position = new Vector3( x, y, z );
				
				ansBox = (AnswerBoxPrefabClass)answerBox[redBoxNumber_current].GetComponent("AnswerBoxPrefabClass");
				ansBox.boxValue = 22;
			
				answerBox_value[redBoxNumber_current]=118;
       		break;
			
			case 23:
				answerBox_picture[redBoxNumber_current] = (GameObject)Instantiate(LetterPrefab_w);
				answerBox_picture[redBoxNumber_current].transform.position = new Vector3( x, y, z );
				
				ansBox = (AnswerBoxPrefabClass)answerBox[redBoxNumber_current].GetComponent("AnswerBoxPrefabClass");
				ansBox.boxValue = 23;
			
				answerBox_value[redBoxNumber_current]=119;
       		break;
			
			case 24:
				answerBox_picture[redBoxNumber_current] = (GameObject)Instantiate(LetterPrefab_x);
				answerBox_picture[redBoxNumber_current].transform.position = new Vector3( x, y, z );
				
				ansBox = (AnswerBoxPrefabClass)answerBox[redBoxNumber_current].GetComponent("AnswerBoxPrefabClass");
				ansBox.boxValue = 24;
			
				answerBox_value[redBoxNumber_current]=120;
       		break;
			
			case 25:
				answerBox_picture[redBoxNumber_current] = (GameObject)Instantiate(LetterPrefab_y);
				answerBox_picture[redBoxNumber_current].transform.position = new Vector3( x, y, z );
				
				ansBox = (AnswerBoxPrefabClass)answerBox[redBoxNumber_current].GetComponent("AnswerBoxPrefabClass");
				ansBox.boxValue = 25;
			
				answerBox_value[redBoxNumber_current]=121;
       		break;
			
			case 26:
				answerBox_picture[redBoxNumber_current] = (GameObject)Instantiate(LetterPrefab_z);
				answerBox_picture[redBoxNumber_current].transform.position = new Vector3( x, y, z );
				
				ansBox = (AnswerBoxPrefabClass)answerBox[redBoxNumber_current].GetComponent("AnswerBoxPrefabClass");
				ansBox.boxValue = 26;
			
				answerBox_value[redBoxNumber_current]=122;
       		break;
			
			default:
        	break;
		}
	}
	
	void wordBoxUpdate ()
	{

		
		
		for(int i=1; i<=8; i++)
		{
			if(wordsLetter_isAvailableChosen[i]==true)
			{
				Color color = renderer.material.color;	
				color.b = 1.0f;
				color.g = 1.0f;
				color.r = 1.0f;
				wordsLetter[i].renderer.material.color=color;
			}
			else if(wordsLetter_isAvailableChosen[i]==false)
			{
				Color color = renderer.material.color;	
				color.b = 0.5f;
				color.g = 0.5f;
				color.r = 0.5f;
				wordsLetter[i].renderer.material.color=color;
			}
			
		}
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(redBoxNumber_previous!=redBoxNumber_current)
		{
			redBoxRemove ();
			redBoxCreate ();
			
			redBoxNumber_previous = redBoxNumber_current;
			//Debug.Log("redBoxNumber is "+redBoxNumber_previous);
		}
		
		if(redBox_update==true)
		{
			//Debug.Log("redBox_value is "+redBox_value);
			redBox_update=false;
			
			//Debug.Log("redBoxNumber_current is "+redBoxNumber_current
			//	+" answer.Length is "+answer.Length);
			
			answerBoxRemove();
			answerBoxUpdate();
	
			//Meng: Move the redbox one position back.
			if(redBoxNumber_current<answer.Length)
			{
				redBoxNumber_current++;
				redBox_x=answerBox[redBoxNumber_current].transform.position.x;
				redBox_y=answerBox[redBoxNumber_current].transform.position.y;
				redBox_z=answerBox[redBoxNumber_current].transform.position.z;
			}
			
			
			//Meng: Calculate if the answer is a correct answer.
			answerIsCorrect=true;
			for(int i=1; i<=answer.Length; i++)
			{
				//Debug.Log("answerBox_value "+i+" is "+answerBox_value[i]);			
				if(answerBox_value[i]!=answer[i-1])
				{
					answerIsCorrect=false;
				}
			}
			
			//Meng: update words box.
			wordBoxUpdate();
			
		}
		
	}
}
