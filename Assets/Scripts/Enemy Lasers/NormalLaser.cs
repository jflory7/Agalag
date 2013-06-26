using UnityEngine;
using System.Collections;

public class NormalLaser : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	rigidbody.AddForce (0, -1000, 0);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (transform.position.y < -17)
		{
			Destroy (gameObject);
		}
	}
	
	void OnCollisionEnter (Collision collision)
	{
		PlayerNormal player = collision.gameObject.GetComponent < PlayerNormal > ();

		if (player != null)
		{
			player.Death ();
		}
		
		Destroy (gameObject);
		
	}
	
}
