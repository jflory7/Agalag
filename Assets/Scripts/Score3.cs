using UnityEngine;
using System.Collections;

public class Score3 : MonoBehaviour 
{
	private EP3 enemies;

	public GUIText mainScore;
	
	// Use this for initialization
	void Start () 
	{
		enemies = GameObject.Find ("tankAlien").GetComponent < EP3 > ();
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
