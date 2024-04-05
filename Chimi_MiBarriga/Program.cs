
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Hamburguesa hamburguesaClasica = new Hamburguesa("Pan Clasico", "Carne Clasica", 100);
        hamburguesaClasica.AgregarIngrediente("Lechuga", 10);
        hamburguesaClasica.AgregarIngrediente("Tomate", 15);
        hamburguesaClasica.AgregarIngrediente("Bacon", 20);
        hamburguesaClasica.AgregarIngrediente("Pepinillo", 10);

        HamburguesaSaludable hamburguesaSaludable = new HamburguesaSaludable("Pan Integral", "Carne de Pavo", 120);
        hamburguesaSaludable.AgregarIngrediente("Lechuga", 10);
        hamburguesaSaludable.AgregarIngrediente("Tomate", 15);

        HamburguesaPremium hamburguesaPremium = new HamburguesaPremium("Pan Premium", "Carne Premium", 150);

        hamburguesaClasica.MostrarDetalles();
        hamburguesaSaludable.MostrarDetalles();
        hamburguesaPremium.MostrarDetalles();
    }
}
