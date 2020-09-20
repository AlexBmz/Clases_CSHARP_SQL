using Practica.JABM3.BEAN;
using Practica.JABM3.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.JABM3
{
    class Program
    {
        static void Main(string[] args)
        {
            ViajeBEAN oViajeBeam = new ViajeBEAN();
            ViajeDAO oViajeDao = new ViajeDAO();
            int opc;
            string rsp = "";

            do
            {
                Console.WriteLine("1 - Registrar Viaje");
                Console.WriteLine("2- Listar Viajes");

                Console.Write("Ingrese una opcion : ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        {

                            Console.Write("Ingrese Id Tarjeta : ");
                            int tarj = int.Parse(Console.ReadLine());

                            Console.Write("Ingrese IdPais : ");
                            int Pais = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese Fecha de Inicio de Viaje : ");
                            DateTime fechIni = DateTime.Parse(Console.ReadLine());
                            Console.Write("Ingrese Fecha de Fin de Viaje : ");
                            DateTime fechFin = DateTime.Parse(Console.ReadLine());
                    
                            oViajeDao.Registro_Y_Listado_Viaje(tarj,Pais,fechIni,fechFin);

                        }
                        break;
                    case 2:
                        {


                            List<ViajeBEAN> listaViajBEAN = oViajeDao.listaViaje();
                            Console.WriteLine("LISTA DE Viajes");
                            Console.WriteLine("");
                            Console.WriteLine("ID VIAJE \t NUMERO-TARJETA \t TIPO-TARJETA \t NOMBRE-PAIS \t FECHA INICIO \t\t\t\t FECHA FIN");
                            Console.WriteLine();
                            for (int i = 0; i < listaViajBEAN.Count; i++)
                            {
                                Console.WriteLine(listaViajBEAN[i].IdViaje + "\t\t" + listaViajBEAN[i].numTarjeta 
                                    + "\t\t\t " + listaViajBEAN[i].TipoTarj
                                    + "\t " + listaViajBEAN[i].nombrePais + "\t\t" + listaViajBEAN[i].FechaInicio + "\t\t" + listaViajBEAN[i].FechaFin);
                            }

                        }
                        break;
                    default:
                        break;
                        
                }
                Console.WriteLine();
                Console.Write("Desea regresar al menu Principal ?(S/N) : ");
                rsp = Console.ReadLine();
            } while (rsp=="s"|| rsp=="S");
        }
    }
}
