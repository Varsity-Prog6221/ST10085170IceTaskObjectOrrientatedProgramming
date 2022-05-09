using System;

public class MattedPhoto : Photo
{
	private String Color;
	


	public MattedPhoto(float fInches, float fHeight, String sColor) : base(fInches, fHeight)
	{

		Color = sColor;
		base.IncreasePrice(10); 
		



	}



	override public string ToString()

	{


		String myString = GetType().ToString() + "         "+ base.GetPrice();
		return myString; 

	}

}	 

