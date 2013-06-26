using UnityEngine;
using System.Collections;

public class Level2Transition : MonoBehaviour
{
	private EP2 enemies;

	// Use this for initialization
	void Start ()
	{
		enemies = GameObject.Find("speedyAlien").GetComponent<EP2>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (enemies.remainingEnemies2 == 0)
		{
			Application.LoadLevel ("Level2Complete");
		}
	}
}
