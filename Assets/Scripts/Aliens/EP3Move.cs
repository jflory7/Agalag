using UnityEngine;
using System.Collections;

public class EP3Move : MonoBehaviour 
{
	public Material explosion;
	
	public Transform laserNormal;
	
	public int Row {get; set;}
	public int Column {get; set;}
	
	private EP3 enemies;
	
	
	void Start ()
	{
		enemies = GameObject.Find ("tankAlien").GetComponent < EP3 > ();	
	}
	
	// Update is called once per frame.
	void Update ()
	{
		transform.position = new Vector3 (transform.position.x, transform.position.y - .003f, transform.position.z);	
		
		CheckFire ();

		if (transform.position.y < -10)
		{
			Application.LoadLevel ("GameOver");
		}
	}
	
	public void Death ()
	{
		renderer.material = explosion;	
	
		rigidbody.velocity = Vector3.zero;
	
		collider.enabled = false;
		
		InvokeRepeating ("AnimateExplosion", .15f, .15f);
		
		enemies.KillEnemy (Column);
	}
	
	private void AnimateExplosion ()
	{
		renderer.material.SetTextureOffset ("_MainTex", new Vector2 (renderer.material.mainTextureOffset.x + .333333333333333f, renderer.material.mainTextureOffset.y));
	
		if (renderer.material.mainTextureOffset.x > 1)
		{
			Destroy (gameObject);	
		}
	}
	
	private void FireLaser ()
	{
		Instantiate (laserNormal, new Vector3 (transform.position.x, transform.position.y - (renderer.bounds.size.y), transform.position.z), Quaternion.identity);
	}
	
	private void CheckFire ()
	{
		if (Random.Range (0, 700) == 42 && enemies.enemiesLeft [Column] == Row)
		{
			FireLaser ();
		}
	}
	
}