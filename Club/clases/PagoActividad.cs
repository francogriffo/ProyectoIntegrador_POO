using System;
using System.Collections.Generic;
using System.Text;

namespace Club.clases
{
    internal class PagoActividad : Pago
    {
        private int idActividad;

        public PagoActividad(int idPago, int idCliente, DateTime fechaPago, double montoPagado, int idActividad)
        : base(idPago, idCliente, fechaPago, montoPagado)
        {
            this.idActividad = idActividad;
        }

        public int IdActividad { get => idActividad; set => idActividad = value; }
    }
}
