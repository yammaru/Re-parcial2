using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entiry
{
    public class ServicioPublico
    {
        public ServicioPublico()
        {
        }

        public ServicioPublico(string nombreServicioPublico, string numeroReciboPago, DateTime fechaPago, decimal valorPago)
        {
            NombreServicioPublico = nombreServicioPublico;
            NumeroReciboPago = numeroReciboPago;
            FechaPago = fechaPago;
            ValorPago = valorPago;
        }

        public string NombreServicioPublico { get; set; }
        public  string NumeroReciboPago { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal ValorPago { get; set; }

        public override string ToString()
        {
            return $"{NombreServicioPublico};{NumeroReciboPago};{FechaPago.ToString("dd/MM/yyyy")};{ValorPago}";
        }

    }
}
