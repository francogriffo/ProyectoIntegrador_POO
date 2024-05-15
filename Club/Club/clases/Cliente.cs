using System;
using System.Collections.Generic;
using System.Text;

namespace Club.clases
{
    internal class Cliente
    {
        private string nombre;
        private string apellido;
        private string direccion;
        private bool aptoFisico;

       
        public Cliente(string nombre, string apellido, string direccion, bool aptoFisico)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.aptoFisico = aptoFisico;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public bool AptoFisico { get => aptoFisico; set => aptoFisico = value; }
    }

}
