class Hamburguesa
{
    protected string TipoPan { get; set; }
    protected string TipoCarne { get; set; }
    protected decimal PrecioBase { get; set; }
    protected List<Ingrediente> IngredientesAdicionales { get; set; }

    public Hamburguesa(string tipoPan, string tipoCarne, decimal precioBase)
    {
        TipoPan = tipoPan;
        TipoCarne = tipoCarne;
        PrecioBase = precioBase;
        IngredientesAdicionales = new List<Ingrediente>();
    }

    public void AgregarIngrediente(string nombre, decimal precio)
    {
        if (IngredientesAdicionales.Count < 4)
        {
            IngredientesAdicionales.Add(new Ingrediente(nombre, precio));
        }
        else
        {
            Console.WriteLine("No se pueden agregar más de 4 ingredientes adicionales.");
        }
    }

    public virtual void MostrarDetalles()
    {
        Console.WriteLine("Hamburguesa Clasica:");
        Console.WriteLine($"- Tipo de Pan: {TipoPan}");
        Console.WriteLine($"- Tipo de Carne: {TipoCarne}");
        Console.WriteLine("- Ingredientes Adicionales:");
        foreach (var ingrediente in IngredientesAdicionales)
        {
            Console.WriteLine($"  - {ingrediente.Nombre}: RD${ingrediente.Precio}");
        }
        Console.WriteLine($"- Precio Total: RD${CalcularPrecio()}");
        Console.WriteLine();
    }

    protected decimal CalcularPrecio()
    {
        decimal precioTotal = PrecioBase + IngredientesAdicionales.Sum(ingrediente => ingrediente.Precio);
        return precioTotal;
    }
}