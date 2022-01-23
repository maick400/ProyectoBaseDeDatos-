using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerminalesProyecto.Cooperativa.Clases;


namespace TerminalesProyecto.Cooperativa.Clases
{
    public class EncomiendaArticulo
    {
        int idEncomienda;
        string descripcion;
        decimal precio;
        char tipo;

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public char Tipo { get => tipo; set => tipo = value; }

    }
}
