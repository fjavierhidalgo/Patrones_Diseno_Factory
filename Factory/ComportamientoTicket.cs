using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class ComportamientoTicket : ComportamientoDocumentoVenta
    {
        int _numerodocumento = -1;
        public override string NombreTipoDocumento => "Ticket";
        public override int NumeroDocumento { get => _numerodocumento; set => _numerodocumento = value; }


        public override bool PeticionCliente()
        {
            return false;
        }

        public override bool PeticionImpuesto()
        {
            return true;
        }
    }
}
