using UnityEngine;
using System.Collections;

public class txt_Play : MonoBehaviour
{
	public void OnMouseDown ()
	{
		Application.LoadLevel ("Level1");
	}
}

//enum Fade {In, Out}
//
//var fadeTime = 4.0;
//
//function Start ()
//{
//    FadeAudio(fadeTime, Fade.Out);
//}
//
//function FadeAudio (timer : float, fadeType : Fade) {
//    var start = fadeType == Fade.In? 0.0 : 1.0;
//    var end = fadeType == Fade.In? 1.0 : 0.0;
//    var i = 0.0;
//    var step = 1.0/timer;
//
//    while (i <= 1.0)
//	{
//        i += step * Time.deltaTime;
//        audio.volume = Mathf.Lerp(start, end, i);
//        yield;
//    }
//}