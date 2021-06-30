using System;

public class Coche
{
	private int id;
	private string marca;
	private string modelo;
	private int km;
	private int precio;

	public Coche(int id, string marca, string modelo, int km, int precio)
	{
		this.id = id;
		this.marca = marca;
		this.modelo = modelo;
		this.km = km;
		this.precio = precio; 
	}

		public int Id { get => id; set => id = value; }
		public string Marca { get => marca; set => marca = value; }
		public string Modelo { get => modelo; set => modelo = value; }
		public int Km { get => km; set => km = value; }
		public int Precio { get => precio; set => precio = value; }

		public string toString()
		{
			return $"Este vehiculo tiene un ID: {id}, Marca: {marca}, Modelo: {modelo}, tiene un Kilometraje de {km} km, y un precio de: {precio} USD";
		}

	
}

    

