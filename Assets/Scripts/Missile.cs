using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour
{

	private PlayerNormal playerNormal;
	private PlayerSpeedy playerSpeedy;
	
	// Use this for initialization
	void Start ()
	{
		// Add initial force.
		rigidbody.AddForce (0, 1000, 0);
		
		// This connects the missile to the normal ship when fired.
		playerNormal = GameObject.Find ("Player Normal").GetComponent < PlayerNormal > ();

		// This connects the missile to the speedy ship when fired.
		playerSpeedy = GameObject.Find ("Player Speedy").GetComponent < PlayerSpeedy > ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (transform.position.y > 17)
		{
			Destroy (gameObject);
			
			playerNormal.HasFired = false;
			
			playerSpeedy.HasFired = false;

		}
	}
}
