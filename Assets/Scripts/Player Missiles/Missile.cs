using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour
{
	private Sounds soundManager;
	
	private PlayerNormal playerNormal;	

	// Use this for initialization
	void Start ()
	{
		// Add initial force.
		rigidbody.AddForce (0, 1000, 0);
		
		// This connects the missile to the normal ship when fired.
		playerNormal = GameObject.Find ("Player Normal").GetComponent < PlayerNormal > ();
		
		soundManager = Camera.main.GetComponent<Sounds>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (transform.position.y > 17)
		{
			Destroy (gameObject);
			
			playerNormal.HasFired = false;
		}
	}
	
	void OnCollisionEnter (Collision collision)
	{
		EP1Move enemy = collision.gameObject.GetComponent < EP1Move > ();

		if (enemy != null)
		{
			enemy.Death ();
		}
		
		soundManager.PlaySound(0);
		
		Destroy (gameObject);
		
		playerNormal.HasFired = false;
	}
}