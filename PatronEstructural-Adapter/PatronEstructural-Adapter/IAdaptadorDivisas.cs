using System;
using System.Collections.Generic;
using System.Text;

namespace PatronEstructural_Adapter
{
    interface IAdaptadorDivisas
    {
        void CambiarEuros(decimal Amount);
        void CambiarDolares(decimal Amount);
        void CambiarReales(decimal Amount);
        void CambiarPesoChileno(decimal Amount);
        void CambiarLibras(decimal Amount);
    }
}
