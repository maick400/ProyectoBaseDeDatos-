using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TerminalesProyecto.Cooperativa.Clases;


namespace TerminalesProyecto.Cooperativa.Clases
{
    public class Bus
    {
        int idbus;
        int idModelo;
        int idCooperativa;
        int anio;
        bool estado;
        string placa;

        public int Idbus { get => idbus; set => idbus = value; }
        public int IdModelo { get => idModelo; set => idModelo = value; }
        public int IdCooperativa { get => idCooperativa; set => idCooperativa = value; }
        public int Anio { get => anio; set => anio = value; }
        public bool Estado { get => estado; set => estado = value; }
        public string Placa { get => placa; set => placa = value; }

        public void Agregar()
        {

        }

        public void Modificar()
        {

        }

        public void Eliminar()
        {

        }

        public  static DataTable ListarOficinistas()
        {
            return new DataTable();
        }
    }
}
