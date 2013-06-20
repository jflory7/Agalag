using UnityEngine;
using System.Collections;

public class MissileBoss : MonoBehaviour
{

	private PlayerBoss playerBoss;
	
	// Use this for initialization
	void Start ()
	{
		// Add initial force.
		rigidbody.AddForce (0, 800, 0);
		
		// This connects the missile to the normal ship when fired.
		playerBoss = GameObject.Find ("Player Boss").GetComponent < PlayerBoss > ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (transform.position.y > 17)
		{
			Destroy (gameObject);
			
			playerBoss.HasFired = false;
		}
	}
}