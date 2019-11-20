using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class ComportamientoFactura : ComportamientoDocumentoVenta
    {
        int _numerodocumento = -1;

        public override string NombreTipoDocumento { get => "Factura"; }
        public override int NumeroDocumento { get => _numerodocumento; set => _numerodocumento = value; }

        public override bool PeticionCliente()
        {
            return true;
        }

        public override bool PeticionImpuesto()
        {
            return true;
        }
    }
}
