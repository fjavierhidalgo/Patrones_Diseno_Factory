using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class ComportamientoDocumentoVenta
    {
        //Establecemos valores a implementar
        public abstract string NombreTipoDocumento { get; }
        public abstract int NumeroDocumento { get; set; }
        //Establecemos una pequeña lógica de comportamiento en los documentos
        public abstract bool PeticionCliente();
        public abstract bool PeticionImpuesto();

    }
}
