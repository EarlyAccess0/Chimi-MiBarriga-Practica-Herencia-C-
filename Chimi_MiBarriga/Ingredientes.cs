class Ingrediente
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }

    public Ingrediente(string nombre, decimal precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
}