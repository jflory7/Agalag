using UnityEngine;
using System.Collections;

public class EP1 : MonoBehaviour 
{
	//Store the amount of aliens left.
	public int remainingEnemies;
	
	//Store the location of the left and right walls.
	private float leftWall;
	private float rightWall;
	public Material explosion;
	
	public int [] enemiesLeft;
	
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
		leftWall = -16f;
		rightWall = 16f;
		
		//Initialize the location of the top row of blocks.
		top = 13f;
		
		//Set enemies remaining to zero.
		remainingEnemies = 0;
		
		//Initialize the aliens on the screen
		InitializeAliens ();
	}
	
	//Initialize the aliens on the screen.
	 public void InitializeAliens ()
	{
		//Calculate the width of the court.
		float courtWidth = Mathf.Abs (leftWall) + Mathf.Abs (rightWall);
		
		//Calculate the number of aliens that can fit in the court.
		float alienNum = 10;
		
		//Calculate the size of the gap between the maximum number of bricksand the edge of the court.
		float endGap = courtWidth - (alienNum * normalAlien.renderer.bounds.size.x);
		
		//Calculate the gap between the blocks.
		float alienGap = endGap / alienNum;
		
		//The y location of the current row of blocks.
		float yPos = top;
		
		//Iterate through six rows of blocks...
		for (float row = top; row > 10; row = row - 1)
		{
			int column = 0;
			
			//..and iterate across the screen using the gap size and block width to guide us.
			for (float xPos = leftWall; xPos <= rightWall; xPos = alienGap + normalAlien.renderer.bounds.size.x + xPos)
			{
				Transform enemy = Instantiate (normalAlien, new Vector3 (xPos, yPos, 24), Quaternion.Euler( new Vector3( 270, 180, 180))) as Transform;
			
				remainingEnemies ++;
				
				EP1Move enemyScript = enemy.GetComponent < EP1Move > ();
				
				enemyScript.Row = (int) row;
				
				enemyScript.Column = column;
				
				column ++;
			}
			
			enemiesLeft = new int [column];
			
			for (int i = 0; i < enemiesLeft.Length; i++) 
			{
				enemiesLeft [i] = (int) row;	
			}
			
			yPos = yPos - normalAlien.renderer.bounds.size.y - alienGap;
		} 
	}
	
	public void KillEnemy (int column)
	{
		enemiesLeft [column] ++;
		remainingEnemies --;
	}
	
}
