using UnityEngine;
using System.Collections;

public class PlayerTank : MonoBehaviour
{
	// Call true-or-false variable to check if the missile has been fired or not.
	public bool HasFired { get; set; }
	
	// Connect the script to the missile?
	public Transform missile;

	// Use this for initialization
	void Start ()
	{
		// Start the game with the missile unfired.
		HasFired = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		PlayerMovement ();
		CheckBoundary ();
		
		// Check to see if the player has fired a missile.
		if (Input.GetButton ("Fire"))
		{
			FireMissile ();
		}
	}

	public void PlayerMovement ()
	{
		if (Input.GetButton ("Left"))
		{
			transform.Translate (5 * Vector3.right * Time.deltaTime);
		}
		if (Input.GetButton ("Right"))
		{
			transform.Translate (5 * Vector3.left * Time.deltaTime);
		}
	}
	
	public void CheckBoundary ()
	{
		// If the player's ship is to the left of the screen...
		if (transform.position.x < -18)
		{
			// ...reset the player's ship to the left of the screen.
			transform.position = new Vector3 (-18, transform.position.y, transform.position.z);
		}
		
		// If the player's ship is to the right of the screen...
		if (transform.position.x > 18)
		{			
			// ...reset the player's ship to the right of the screen.
			transform.position = new Vector3 (18, transform.position.y, transform.position.z);
		}
		// Prevent movement on the z-axis.
		transform.position = new Vector3 (transform.position.x, transform.position.y, 24);
	}
	
	// Fire a new missile.
	private void FireMissile ()
	{
		// If the missile is not fired...
		if (!HasFired)
		{
			// ...create a new missile, and then...
			Instantiate (missile, new Vector3 (transform.position.x, transform.position.y + (renderer.bounds.size.y / 2), 24), Quaternion.identity);
			
			// ...change the state of the missile to fired.
			HasFired = true;
		}
	}
}