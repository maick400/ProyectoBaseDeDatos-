using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace TerminalesProyecto.Cooperativa.Clases
{
    public class Cooperativa
    {
        int idCooperativa;
        string nombre;
        string ruc;
        string telefono;
        string matriz;
        Image logo;

        public int IdCooperativa { get => idCooperativa; set => idCooperativa = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Ruc { get => ruc; set => ruc = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Matriz { get => matriz; set => matriz = value; }
        public Image Logo { get => logo; set => logo = value; }

    }
}
