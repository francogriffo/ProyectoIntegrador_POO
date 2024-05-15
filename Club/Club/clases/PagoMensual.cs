using System;
using System.Collections.Generic;
using System.Text;

namespace Club.clases
{
    internal class PagoMensual : Pago
    {
        private DateTime fechaVencimiento;

        public PagoMensual(int idPago, int idCliente, DateTime fechaPago, double montoPagado, DateTime fechaVencimiento)
        : base(idPago, idCliente, fechaPago, montoPagado)
        {
            this.fechaVencimiento = fechaVencimiento;
        }

        public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
    }
}