using UnityEngine;
using System.Collections;

public class TankLaser : MonoBehaviour 
{
	private Sounds soundManager;

	// Use this for initialization
	void Start () 
	{
		rigidbody.AddForce (0, -800, 0);
		
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
		PlayerTank player = collision.gameObject.GetComponent < PlayerTank > ();

		if (player != null)
		{
			player.Death ();
		}
		soundManager.PlaySound(0);
	}
}
