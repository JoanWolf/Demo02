namespace MyLibrary;

public class Product(int id, string name, decimal unitPrice, int unitInStock)
{
	//Propiedades
	public int Id { get; } = id;
	public string Name { get;} = name;
	public decimal UnitPrice { get;} = unitPrice;
	public int UnitInStock { get; } = unitInStock;

}



