using UnityEngine;
using System.Collections;

public class MissileSpeedy : MonoBehaviour
{
	private Sounds soundManager;
	
	private PlayerSpeedy playerSpeedy;
	
	// Use this for initialization
	void Start ()
	{
		// Add initial force.
		rigidbody.AddForce (0, 1250, 0);

		// This connects the missile to the speedy ship when fired.
		playerSpeedy = GameObject.Find ("Player Speedy").GetComponent < PlayerSpeedy > ();
		
		soundManager = Camera.main.GetComponent<Sounds>();
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
	
		
void OnCollisionEnter (Collision collision)
	{
		
		EP2Move enemy = collision.gameObject.GetComponent < EP2Move > ();

		if (enemy != null)
		{
			enemy.Death ();
		}
		
		soundManager.PlaySound(0);
		
		Destroy (gameObject);
		
		playerSpeedy.HasFired = false;
	
	}
}
