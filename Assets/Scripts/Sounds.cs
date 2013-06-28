using UnityEngine;
using System.Collections;

public class Sounds : MonoBehaviour 
{
	// The array of sounds set in the editor
	public AudioSource[] sounds;

	//Playsn a sound corresponding to a #
	public void PlaySound (int num)
	{
	 	sounds [num].Play ();
	}
}