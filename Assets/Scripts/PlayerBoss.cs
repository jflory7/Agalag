using UnityEngine;
using System.Collections;

public class PlayerBoss : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		PlayerMovement ();
		CheckBoundary ();
	}
	
	public void PlayerMovement ()
	{
		if (Input.GetButton ("Left"))
		{
			transform.Translate (10 * Vector3.right * Time.deltaTime);
		}
		if (Input.GetButton ("Right"))
		{
			transform.Translate (10 * Vector3.left * Time.deltaTime);
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
}