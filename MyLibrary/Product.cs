﻿namespace MyLibrary;

public class Product(int id, string name, decimal unitPrice, int unitInStock)
{
	//Propiedades
	public int Id  => id;
	public string Name => name;
	public decimal UnitPrice => unitPrice;
	public int UnitInStock => unitInStock;
	public bool Discontinued {  get; private set; }

	public void SetDiscontinued()
	{
		Discontinued = true;
	}
	public bool GetStatus()
	{
		return Discontinued;
	}
}

//public class Product2(int id, string name,
//	bool discontinued) : Product(id, name, default, default)
//{
//	public bool Discontinued { get; set; } = discontinued;

//}




