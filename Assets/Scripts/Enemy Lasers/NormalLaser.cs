using UnityEngine;
using System.Collections;

public class NormalLaser : MonoBehaviour 
{
	private Sounds soundManager;

	// Use this for initialization
	void Start () 
	{
		rigidbody.AddForce (0, -1000, 0);
		
		soundManager = Camera.main.GetComponent<Sounds>();
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
		soundManager.PlaySound(0);
		
		Destroy (gameObject);
	}
	
}
