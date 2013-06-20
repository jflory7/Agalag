using UnityEngine;
using System.Collections;

public class MissileTank : MonoBehaviour 
{

	private PlayerTank playerTank;
	
	// Use this for initialization
	void Start ()
	{
		// Add initial force.
		rigidbody.AddForce (0, 1000, 0);
		
		// This connects the missile to the normal ship when fired.
		playerTank = GameObject.Find ("Player Tank").GetComponent < PlayerTank > ();
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
}
