using UnityEngine;
using System.Collections;

public class PlayerSpeedy : MonoBehaviour 
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
	// Check the position of the ship compared to the boundaries.
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
}
