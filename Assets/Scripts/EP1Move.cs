using UnityEngine;
using System.Collections;

public class EP1Move : MonoBehaviour 
{
	// Update is called once per frame.
	void Update ()
	{
		transform.position = new Vector3 (transform.position.x, transform.position.y - .005f, transform.position.z);	
	}
}
