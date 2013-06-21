using UnityEngine;
using System.Collections;

public class MissileSpeedy : MonoBehaviour
{
	private PlayerSpeedy playerSpeedy;
	
	// Use this for initialization
	void Start ()
	{
		// Add initial force.
		rigidbody.AddForce (0, 1000, 0);

		// This connects the missile to the speedy ship when fired.
		playerSpeedy = GameObject.Find ("Player Speedy").GetComponent < PlayerSpeedy > ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (transform.position.y > 17)
		{
			Destroy (gameObject);
						
			playerSpeedy.HasFired = false;
		}
	}
}
