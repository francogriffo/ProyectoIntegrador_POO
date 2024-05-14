using System;
using System.Collections.Generic;
using System.Text;

namespace Club.clases
{
    internal class Pago
    {
        private int idPago;
        private int idCliente;
        private DateTime fechaPago;
        private double montoPagado;

        public Pago(int idPago, int idCliente, DateTime fechaPago, double montoPagado)
        {
            this.idPago = idPago;
            this.idCliente = idCliente;
            this.fechaPago = fechaPago;
            this.montoPagado = montoPagado;
        }

        public int IdPago { get => idPago; set => idPago = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public DateTime FechaPago { get => fechaPago; set => fechaPago = value; }
        public double MontoPagado { get => montoPagado; set => montoPagado = value; }
    }
}
