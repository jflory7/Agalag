using UnityEngine;
using System.Collections;
public class Background : MonoBehaviour
{
 // Use this for initialization
 void Start ()
 {
 
 }
 
 // Update is called once per frame
 void Update ()
 {
  transform.Translate (Vector3.forward * 5 * Time.deltaTime);
  
  if (transform.position.y < -22)
  {
   transform.position = new Vector3 (0, 27, 25); 
  }
 }
}