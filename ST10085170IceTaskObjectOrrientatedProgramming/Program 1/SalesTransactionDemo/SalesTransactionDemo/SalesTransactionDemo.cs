using System;

public class SalesTransactionDemo1
{

	private String name;
	private float SalesAmount;
	private float commission;
	private float commissionrate; 



	public SalesTransactionDemo1(String sName, float fSalesAmount, float fCommissionRate )
	{


		name = sName;
		SalesAmount = fSalesAmount;
		commissionrate = fCommissionRate;
		commission = (commissionrate/100) * SalesAmount; 




	}


	public SalesTransactionDemo1(String sName, float fSalesAmount)
	{

		name = sName;
		SalesAmount = fSalesAmount;
		commissionrate = 0; 

	
	
	
	
	}



	public SalesTransactionDemo1(String sName)

	{

		name = sName;
		SalesAmount = 0;
		commission = 0;
		commissionrate = 0; 
	
	
	}


	public void Display()
	{



        Console.WriteLine(name + "           " + commission);
	
	
	
	}

}
