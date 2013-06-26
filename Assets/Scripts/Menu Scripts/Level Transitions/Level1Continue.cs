using UnityEngine;
using System.Collections;

public class Level1Continue : MonoBehaviour
{
	public AudioSource music;
	
	public void OnMouseDown ()
	{
		FadeAudio(0.1f);
	}
	
	private void FadeAudio (float timer)
	{
		float t = 1;
		while (t > 0)
		{
			t -= Time.deltaTime * timer;
			music.volume = t;
		}
		music.Stop ();
		Application.LoadLevel ("Level2");
	}
}
