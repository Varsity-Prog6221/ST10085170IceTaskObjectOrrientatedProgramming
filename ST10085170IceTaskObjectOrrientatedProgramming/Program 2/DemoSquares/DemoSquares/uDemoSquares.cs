using System;

public class Squares
{
	private float area;
	private float side; 
	
	
	public Squares(float fside)
	{

		side = fside;
		area = side * side; 


	}




	public float ReturnArea()
	{


		return area; 
	
	}
}
