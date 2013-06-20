using UnityEngine;
using System.Collections;

public class TextControl : MonoBehaviour
{
	bool txt_Exit = false;
	
	// Detect the player's mouse.
	public void OnMouseEnter ()
	{
		// Change the color of the text.
		renderer.material.color = Color.red;
	}
	
	// Detect the player's mouse.
	public void OnMouseExit ()
	{
		// Change the color of the text.
		renderer.material.color = Color.white;
	}
}
