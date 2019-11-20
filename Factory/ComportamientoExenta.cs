using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class ComportamientoExenta : ComportamientoDocumentoVenta
    {
        int _numerodocumento = -1;

        public override string NombreTipoDocumento => "Exenta";
        public override int NumeroDocumento { get => _numerodocumento; set => _numerodocumento = value; }

        public override bool PeticionCliente()
        {
            return true;
        }

        public override bool PeticionImpuesto()
        {
            return false;
        }
    }
}
