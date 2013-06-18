using UnityEngine;
using System.Collections;

public class PlayerSpeedy : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		CheckBoundary ();
	}
	// Check the position of the ship compared to the boundaries.
	public void CheckBoundary ()
	{
		if (Input.GetButton ("Right"))
		{
			transform.Translate (15 * Vector3.left * Time.deltaTime);
		}
		
		if (Input.GetButton ("Left"))
		{
			transform.Translate (15 * Vector3.right * Time.deltaTime);	
		}
		
		if (transform.position.x > 18)
		{
			transform.position = new Vector3 (18, transform.position.y, transform.position.z);	
		}
		
		if (transform.position.x < -18)
		{
			transform.position = new Vector3 (-18, transform.position.y, transform.position.z);	
		}
		transform.position = new Vector3 (transform.position.x, transform.position.y, 24);
	}
}
