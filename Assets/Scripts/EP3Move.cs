using UnityEngine;
using System.Collections;

public class EP3Move : MonoBehaviour 
{
	public Material explosion;
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = new Vector3 (transform.position.x, transform.position.y - .003f, transform.position.z);
	}

	public void Death ()
	{
		renderer.material = explosion;	
	
		rigidbody.velocity = Vector3.zero;
	
		collider.enabled = false;
		
		InvokeRepeating ("AnimateExplosion", .15f, .15f);
	}
	
	private void AnimateExplosion ()
	{
		renderer.material.SetTextureOffset ("_MainTex", new Vector2 (renderer.material.mainTextureOffset.x + .333333333333333f, renderer.material.mainTextureOffset.y));
	
		if (renderer.material.mainTextureOffset.x > 1)
		{
			Destroy (gameObject);	
		}
	}
}
