using UnityEngine;
using System.Collections;

public class ReturnToMenu : MonoBehaviour
{
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButton ("Menu"))
			Application.LoadLevel ("Menu");
	}
}
