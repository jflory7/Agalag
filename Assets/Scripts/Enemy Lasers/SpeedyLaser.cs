using UnityEngine;
using System.Collections;

public class SpeedyLaser : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	rigidbody.AddForce (0, -1500, 0);
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
		PlayerSpeedy player = collision.gameObject.GetComponent < PlayerSpeedy > ();

		if (player != null)
		{
			player.Death ();
		}
		
		Destroy (gameObject);
		
	}
	
}
