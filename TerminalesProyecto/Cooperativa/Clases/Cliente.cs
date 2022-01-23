using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TerminalesProyecto.Cooperativa.Clases
{
    public class Cliente
    {
        int idCliente;
        string nombres;
        string apellidos;
        string cedula;
        string direccion;
        string Ciudad;
        string telefono1;
        string telefono2;
        string email;
        string tipoSangre;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad1 { get => Ciudad; set => Ciudad = value; }
        public string Telefono1 { get => telefono1; set => telefono1 = value; }
        public string Telefono2 { get => telefono2; set => telefono2 = value; }
        public string Email { get => email; set => email = value; }
        public string TipoSangre { get => tipoSangre; set => tipoSangre = value; }

        public void Agregar()
        {

        }

        public void Modificar()
        {

        }

        public void Eliminar()
        {

        }

        public static DataTable ListarModelos()
        {
            return new DataTable();


        }
    }
}
