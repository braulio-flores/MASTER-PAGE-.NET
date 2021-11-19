using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entregable4
{
    public class Platillo
    {
        private int id;
        private string nombre;
        private string pais;

        public Platillo(int id, string nombre, string pais)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Pais = pais;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Pais { get => pais; set => pais = value; }
    }
}