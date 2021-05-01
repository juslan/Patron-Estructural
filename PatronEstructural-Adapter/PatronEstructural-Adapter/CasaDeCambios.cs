using System;
using System.Collections.Generic;
using System.Text;

namespace PatronEstructural_Adapter
{
    class CasaDeCambios
    {
        private decimal flujo;
        public CasaDeCambios()
        {
            flujo = 0;
        }

        public void AñadirFlujo(decimal amount)
        {
            flujo += amount;
        }
        public string GetFlujoActual()
        {
            return $"Su flujo actual es:{flujo}";
        }
    }
}
