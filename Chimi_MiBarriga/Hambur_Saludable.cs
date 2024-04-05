class HamburguesaSaludable : Hamburguesa
{
    public HamburguesaSaludable(string tipoPan, string tipoCarne, decimal precioBase) : base(tipoPan, tipoCarne, precioBase)
    {
       
        IngredientesAdicionales = new List<Ingrediente>();
    }

    public override void MostrarDetalles()
    {
        Console.WriteLine("Hamburguesa Saludable:");
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

    public void AgregarIngredienteSaludable(string nombre, decimal precio)
    {
        if (IngredientesAdicionales.Count < 6)
        {
            IngredientesAdicionales.Add(new Ingrediente(nombre, precio));
        }
        else
        {
            Console.WriteLine("No se pueden agregar más de 6 ingredientes adicionales a la Hamburguesa Saludable.");
        }
    }
}