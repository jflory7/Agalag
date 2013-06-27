using UnityEngine;
using System.Collections;

public class Score1 : MonoBehaviour 
{
	private EP1 enemies;

	public GUIText mainScore;
	
	// Use this for initialization
	void Start () 
	{
		enemies = GameObject.Find ("normalAlien").GetComponent < EP1 > ();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
		void OnGUI () 
	{
		//update score display with the values of the gamestate.
		mainScore.text = "" + enemies.score;
	}
	
}
