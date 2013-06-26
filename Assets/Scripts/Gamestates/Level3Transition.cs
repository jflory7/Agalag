using UnityEngine;
using System.Collections;

public class Level3Transition : MonoBehaviour
{
	private EP3 enemies;

	// Use this for initialization
	void Start ()
	{
		enemies = GameObject.Find("tankAlien").GetComponent<EP3>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (enemies.remainingEnemies3 == 0)
		{
			Application.LoadLevel ("Level3Complete");
		}
	}
}
