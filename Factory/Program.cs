using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Probamos los tres tipos definidos

            ComportamientoDocumentoVenta oDocumento = CreadorDocumentos.CreaDocumentoVenta(CreadorDocumentos.FACTURA);
            oDocumento.NumeroDocumento = 1;   //Pediríamos número a la lógica encargada de los contadores
            Peticiones(oDocumento);

            oDocumento = CreadorDocumentos.CreaDocumentoVenta(CreadorDocumentos.TICKET);
            oDocumento.NumeroDocumento = 25;  //Pediríamos número a la lógica encargada de los contadores
            Peticiones(oDocumento);

            oDocumento = CreadorDocumentos.CreaDocumentoVenta(CreadorDocumentos.EXENTA);
            oDocumento.NumeroDocumento = 11;
            Peticiones(oDocumento);

        }

        // Simulamos una capa de presentación que comprueba las peticiones para el documento
        private static void Peticiones(ComportamientoDocumentoVenta Documento)
        {
            string tipodoc = Documento.NombreTipoDocumento;
            string numdoc = Documento.NumeroDocumento.ToString();

            if (Documento.PeticionCliente())
                Console.WriteLine("Para " + tipodoc + " Número: " + numdoc + " - Indique Cliente:");
            if (Documento.PeticionImpuesto())
                Console.WriteLine("Para " + tipodoc + " Número: " + numdoc + " - Indique IVA:");
        }
    }
}
