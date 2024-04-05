class HamburguesaPremium : Hamburguesa
{
    public HamburguesaPremium(string tipoPan, string tipoCarne, decimal precioBase) : base(tipoPan, tipoCarne, precioBase)
    {
       
        IngredientesAdicionales = new List<Ingrediente> { new Ingrediente("Papitas", 50), new Ingrediente("Bebida", 30) };
    }

    public override void MostrarDetalles()
    {
        Console.WriteLine("Hamburguesa Premium:");
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

    public void AgregarIngredientePremium()
    {
        Console.WriteLine("No se permiten agregar más ingredientes a la Hamburguesa Premium.");
    }
}