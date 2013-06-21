using UnityEngine;
using System.Collections;

public class PlayerSpeedy : MonoBehaviour 
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
		if (Input.GetButton ("Up"))
		{
			transform.Translate(Vector3.up * 15 * Time.deltaTime, Space.World);
		}
		if (Input.GetButton ("Down"))
		{
			transform.Translate (Vector3.down * 15 * Time.deltaTime, Space.World);	
		}
		if (Input.GetButton ("Right"))
		{
			transform.Translate (15 * Vector3.left * Time.deltaTime);
		}
		
		if (Input.GetButton ("Left"))
		{
			transform.Translate (15 * Vector3.right * Time.deltaTime);	
		}
	}

	public void CheckBoundary ()
	{
		if (transform.position.x > 18)
		{
			transform.position = new Vector3 (18, transform.position.y, transform.position.z);	
		}
		
		if (transform.position.x < -18)
		{
			transform.position = new Vector3 (-18, transform.position.y, transform.position.z);	
		}
		transform.position = new Vector3 (transform.position.x, transform.position.y, 24);
		
		if (transform.position.y  > -8)
		{
			transform.position = new Vector3 (transform.position.x, -8, transform.position.z);	
		}
		
		if (transform.position.y < -13)
		{
			transform.position = new Vector3 (transform.position.x, -13, transform.position.z);	
		}
	}
	
	// Fire a new missile.
	private void FireMissile ()
	{
		// If the missile is not fired...
		if (!HasFired)
		{
			// ...create a new missile, and then...
			Instantiate (missile, new Vector3 (transform.position.x, transform.position.y + (renderer.bounds.size.y / 2) + 1, 24), Quaternion.identity);
			
			// ...change the state of the missile to fired.
			HasFired = true;
		}
	}
}