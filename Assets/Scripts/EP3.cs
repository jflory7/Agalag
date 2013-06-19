using UnityEngine;
using System.Collections;

public class EP3 : MonoBehaviour 
{
	//Store the location of the left and right walls.
	private float leftWall;
	private float rightWall;
	
	//Store the top location of aliens.
	private float top;
	
	//Transforms for the three types of aliens we will use.
	public Transform normalAlien;
	public Transform speedyAlien;
	public Transform tankAlien;

	// Use this for initialization
	void Start () 
	{
		//Initialize the course's boundaries.
		leftWall = -10f;
		rightWall = 10f;
		
		//Initialize the location of the top row of blocks.
		top = 13f;
		
		//Initialize the aliens on the screen
		InitializeAliens ();
	}
	
	//Initialize the aliens on the screen.
	 public void InitializeAliens ()
	{
		//Calculate the width of the court.
		float courtWidth = Mathf.Abs (leftWall) + Mathf.Abs (rightWall);
		
		//Calculate the number of aliens that can fit in the court.
		float alienNum = 8;
		
		//Calculate the size of the gap between the maximum number of bricksand the edge of the court.
		float endGap = courtWidth - (alienNum * tankAlien.renderer.bounds.size.x);
		
		//Calculate the gap between the blocks.
		float alienGap = endGap / alienNum;
		
		//The y location of the current row of blocks.
		float yPos = top;
		
		//Iterate through six rows of blocks...
		for (float row = top; row > 10; row = row - 1)
		{
			//..and iterate across the screen using the gap size and block width to guide us.
			for (float xPos = leftWall; xPos <= rightWall; xPos = alienGap + tankAlien.renderer.bounds.size.x + xPos)
			{
				Instantiate (tankAlien, new Vector3 (xPos, yPos, 8), Quaternion.Euler( new Vector3( 270, 180, 180)));
			}
			
			
			yPos = yPos - tankAlien.renderer.bounds.size.y - alienGap;
		} 
	}
}
