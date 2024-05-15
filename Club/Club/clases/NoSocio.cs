using System;
using System.Collections.Generic;
using System.Text;

namespace Club.clases
{
    internal class NoSocio : Cliente
    {
        private DateTime fechaAlta;

        public NoSocio(string nombre, string apellido, string direccion, bool aptoFisico, DateTime fechaAlta)
            : base(nombre, apellido, direccion, aptoFisico)
        {
            this.fechaAlta = fechaAlta;
        }

        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
    }
}
