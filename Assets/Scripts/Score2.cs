using UnityEngine;
using System.Collections;

public class Score2 : MonoBehaviour 
{
	private EP2 enemies;

	public GUIText mainScore;
	
	// Use this for initialization
	void Start () 
	{
		enemies = GameObject.Find ("speedyAlien").GetComponent < EP2 > ();
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
