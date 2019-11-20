using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class CreadorDocumentos
    {
        public const int FACTURA = 1;
        public const int TICKET = 2;
        public const int EXENTA = 3;

        public static ComportamientoDocumentoVenta CreaDocumentoVenta( int Tipo )
        {
            switch(Tipo)
            {
                case FACTURA:

                    return new ComportamientoFactura();

                case TICKET:

                    return new ComportamientoTicket();

                case EXENTA:

                    return new ComportamientoExenta();

                default: return null;
            }
        }


    }
}
