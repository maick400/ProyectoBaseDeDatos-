using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TerminalesProyecto.Cooperativa.Clases;


namespace TerminalesProyecto.Cooperativa.Clases
{
    public class Chofer:Personal
    {
        int idChofer;
        char licencia;
        bool estado;

        public int IdChofer { get => idChofer; set => idChofer = value; }
        public char Licencia { get => licencia; set => licencia = value; }
        public bool Estado { get => estado; set => estado = value; }

        public void Agregar()
        {

        }

        public void Modificar()
        {

        }

        public void Eliminar()
        {

        }



        public DataTable ListarOficinistas()
        {
            return new DataTable();
        }

    }
}
