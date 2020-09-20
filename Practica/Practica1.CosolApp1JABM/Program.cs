using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.CosolApp1JABM
{
    class Program
    {
        static void Main(string[] args)
        {
            string rsp = "";
            int opc2;
            int opc3;
            string rsp2 = "";
            String rsp3 = "";
            string rsp4 = "";
            ClienteDAO oClienteDAO = new ClienteDAO();
            PaisDAO oPaisDAO = new PaisDAO();
            TarjetaDAO oTarjDAO = new TarjetaDAO();
            do
            {
                Console.WriteLine("1 - Registrar ");
                Console.WriteLine("2 - Listar ");
                Console.WriteLine("3 - Actualizar");
                Console.WriteLine("\n Ingrese una Opcion");
                int opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        {
                            do
                            {
                                Console.WriteLine("1 - Registrar Cliente ");
                                Console.WriteLine("2 - Registrar Tarjeta ");
                                Console.WriteLine("3 - registrar Pais");
                                Console.Write("\n Ingrese una Opcion : ");
                                opc2 = int.Parse(Console.ReadLine());
                                switch (opc)
                                {
                                    case 1:
                                        {
                                            oClienteDAO.RegistrarCliente();
                                        }
                                        break;
                                    case 2:
                                        {
                                            oTarjDAO.RegistrarTarjeta();
                                        }
                                        break;
                                    case 3:
                                        {
                                            oPaisDAO.RegistrarPais();
                                        }
                                        break;
                                    default:
                                        break;
                                }
                                Console.WriteLine("Desea Regresar al menu de Registro ? : (S/N)");
                                rsp2 = Console.ReadLine();
                                Console.WriteLine();


                            } while (rsp == "s" || rsp == "S");

                        }
                        break;

                    case 2:
                        {
                            do
                            {
                                Console.WriteLine("1 - Listar Cliente ");
                                Console.WriteLine("2 - Listar Tarjeta ");
                                Console.WriteLine("3 - Listar Pais");
                                Console.Write("\n Ingrese una Opcion : ");
                                opc2 = int.Parse(Console.ReadLine());
                                switch (opc2)
                                {
                                    case 1:
                                        {
                                            oClienteDAO.ListarCliente();
                                        }
                                        break;
                                    case 2:
                                        {
                                            oTarjDAO.ListarTarjeta();
                                        }
                                        break;
                                    case 3:
                                        {
                                            oPaisDAO.ListarPais();
                                        }
                                        break;
                                    default:
                                        break;
                                }
                                Console.WriteLine("Desea Regresar al menu de Listado ? : (S/N)");
                                rsp3 = Console.ReadLine();
                                Console.WriteLine();

                            } while ((rsp3 == "s" || rsp3 == "S"));
                        }
                
                        break;

                    case 3:
                        {
                            do
                            {
                                Console.WriteLine("1 - Actualizar Cliente ");
                                Console.WriteLine("2 - Actualizar Tarjeta ");
                                Console.WriteLine("3 - Actualizar Pais");
                                Console.Write("\n Ingrese una Opcion : ");
                                opc3 = int.Parse(Console.ReadLine());
                                switch (opc3)
                                {
                                    case 1:
                                        {
                                            oClienteDAO.ActualizarCliente();
                                        }
                                        break;
                                    case 2:
                                        {
                                            oPaisDAO.ActualizarPais();
                                        }
                                        break;
                                    case 3:
                                        {
                                            oPaisDAO.ActualizarPais();
                                        }
                                        break;
                                    default:
                                        break;
                                }
                                Console.WriteLine("Desea Regresar al menu de Actualizado ? : (S/N)");
                                rsp4= Console.ReadLine();
                                Console.WriteLine();

                            } while ((rsp4 == "s" || rsp4 == "S"));
                        }
                        break;

                    default:
                        break;
                }

                Console.Write("Desea regresar al menu principal ?(S/N)  :");
                rsp = Console.ReadLine();


            } while (rsp=="s"|| rsp=="S");
        }
    }
}
