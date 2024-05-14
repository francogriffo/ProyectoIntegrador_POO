using System;
using System.Collections.Generic;
using System.Text;

namespace Club.clases
{
    internal class Socio : Cliente
    {

        private int numeroSocio;
        private int numeroCarnet;
        private DateTime fechaAlta;

        public Socio(string nombre, string apellido, string direccion, bool aptoFisico, int numeroSocio, int numeroCarnet, DateTime fechaAlta)
            : base(nombre, apellido, direccion, aptoFisico)
        {
            this.numeroSocio = numeroSocio;
            this.numeroCarnet = numeroCarnet;
            this.fechaAlta = fechaAlta;
        }

        public int NumeroSocio { get => numeroSocio; set => numeroSocio = value; }
        public int NumeroCarnet { get => numeroCarnet; set => numeroCarnet = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
    }
}
    
