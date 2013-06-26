using UnityEngine;
using System.Collections;

public class Level1Transition : MonoBehaviour
{
	private EP1 enemies;

	// Use this for initialization
	void Start ()
	{
		enemies = GameObject.Find("normalAlien").GetComponent<EP1>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (enemies.remainingEnemies1 == 0)
		{
			Application.LoadLevel ("Level1Complete");
		}
	}
}
