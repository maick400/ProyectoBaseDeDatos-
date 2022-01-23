using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerminalesProyecto.Cooperativa.Clases;
using System.Data;


namespace TerminalesProyecto.Cooperativa.Clases
{
    public class Boleto
    {
        int id;
        Oficinista oficinista;
        DetalleViaje detalleViaje;
        Cliente cliente;
        Destino destino;
        decimal precioUnitario;
        List<BoletoAsiento> asientos;


        


        


        public void Agregar()
        {

        }

        public void Modificar()
        {

        }

        public void Eliminar()
        {

        }

        public static DataTable ListarOficinistas()
        {
            return new DataTable();

        }

        }
    }
