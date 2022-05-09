using System;

public class FramedPhoto : Photo
{

	String Material;
	String Style; 

	public FramedPhoto(float fInchesHeight, float fInchesWidth, String sMaterial, String sStyle ) : base(fInchesHeight, fInchesWidth)
	{
		Material = sMaterial;
		Style = sStyle;

		base.IncreasePrice(25); 




	}


	override public string ToString()
	{

		String myString = GetType().ToString() + "         " + base.GetPrice();
		return myString; 


	}





}
