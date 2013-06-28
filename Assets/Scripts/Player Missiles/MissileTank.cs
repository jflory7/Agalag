using UnityEngine;
using System.Collections;

public class MissileTank : MonoBehaviour 
{
	private Sounds soundManager;
	
	private PlayerTank playerTank;
	
	// Use this for initialization
	void Start ()
	{
		// Add initial force.
		rigidbody.AddForce (0, 800, 0);
		
		// This connects the missile to the normal ship when fired.
		playerTank = GameObject.Find ("Player Tank").GetComponent < PlayerTank > ();
		
		soundManager = Camera.main.GetComponent<Sounds>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (transform.position.y > 17)
		{
			Destroy (gameObject);
			
			playerTank.HasFired = false;
		}
	}
	
		
	void OnCollisionEnter (Collision collision)
	{
		
		EP3Move enemy = collision.gameObject.GetComponent < EP3Move > ();

		if (enemy != null)
		{
			enemy.Death ();
		}
		
		soundManager.PlaySound(0);
		
		Destroy (gameObject);
		
		playerTank.HasFired = false;
	
	}
	
	
}
