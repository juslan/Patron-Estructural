using System;

namespace PatronEstructural_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Adaptador adaptador = new Adaptador();
            adaptador.CambiarDolares(640);
            Console.WriteLine(adaptador.GetFlujoActual());
            adaptador.CambiarReales(5000);
            Console.WriteLine(adaptador.GetFlujoActual());
            adaptador.CambiarPesoChileno(5431600);
            Console.WriteLine(adaptador.GetFlujoActual());
            adaptador.CambiarLibras(46);
            Console.WriteLine(adaptador.GetFlujoActual());
            adaptador.CambiarEuros(300);
            Console.WriteLine(adaptador.GetFlujoActual());
        }
    }
}
