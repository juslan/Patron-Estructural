using System;
using System.Collections.Generic;
using System.Text;

namespace PatronEstructural_Adapter
{
    class Adaptador : CasaDeCambios, IAdaptadorDivisas
    {
        public void CambiarDolares(decimal Amount)
        {
            decimal cantidadBolivianos = Amount * 6.94m;
            Console.WriteLine($"-------Debe dar {cantidadBolivianos} bolivianos");
            AñadirFlujo(cantidadBolivianos);
        }

        public void CambiarEuros(decimal Amount)
        {
            decimal cantidadBolivianos = Amount * 8.28m;
            Console.WriteLine($"-------Debe dar {cantidadBolivianos} bolivianos");
            AñadirFlujo(cantidadBolivianos);
        }

        public void CambiarLibras(decimal Amount)
        {
            decimal cantidadBolivianos = Amount * 9.52m;
            Console.WriteLine($"-------Debe dar {cantidadBolivianos} bolivianos");
            AñadirFlujo(cantidadBolivianos);
        }

        public void CambiarPesoChileno(decimal Amount)
        {
            decimal cantidadBolivianos = Amount * 0.00966m;
            Console.WriteLine($"-------Debe dar {cantidadBolivianos} bolivianos");
            AñadirFlujo(cantidadBolivianos);
        }

        public void CambiarReales(decimal Amount)
        {
            decimal cantidadBolivianos = Amount * 1.26245m;
            Console.WriteLine($"-------Debe dar {cantidadBolivianos} bolivianos");
            AñadirFlujo(cantidadBolivianos);
        }
    }
}
