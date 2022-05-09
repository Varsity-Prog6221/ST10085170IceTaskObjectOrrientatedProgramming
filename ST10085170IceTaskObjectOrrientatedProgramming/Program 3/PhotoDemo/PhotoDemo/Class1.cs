using System;

public class Photo
{

	private float InchesHeight;
	private float InchesWidth;
	private double price;
	public Photo(float fInchesHeight, float fInchesWidth)



	{

		InchesHeight = fInchesHeight;
		InchesWidth = fInchesWidth;


		if ((InchesHeight == 8) && (InchesWidth == 10))



		{

			price = 3.99;


		}

		else
			if ((InchesHeight == 10) && (InchesWidth == 10))
		{

			price = 5.99;


		}

		else

		{

			price = 9.99;

		} 
	
	
	}



	public double GetPrice()
	{


		return price; 
	}



	public string toString()
	{

		String myString = GetType().ToString() + InchesHeight + InchesWidth + price;

		return myString; 


    }


	public void IncreasePrice(float Increase)
	{

		price = price + Increase; 
	
	
	}




}

