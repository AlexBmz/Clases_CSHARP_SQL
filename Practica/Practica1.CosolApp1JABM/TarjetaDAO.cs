using Practica1.CosolApp1JABM.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.CosolApp1JABM
{
    public class TarjetaDAO
    {

        public void RegistrarTarjeta()
        {

            ClienteDAO oCliDao = new ClienteDAO();
            oCliDao.ListarCliente();
            Console.WriteLine();
            Console.Write("Ingrese el numero de tarjeta : ");
            string _NumTarj = (Console.ReadLine());
            Console.WriteLine(" Ingrese el tipo de tarjeta : ");
            string _tipoTarj = Console.ReadLine();
            Console.WriteLine("Ingrese el modo de pago : ");
            string _ModoPago = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de Vencimiento : ");
            string _FechaVenc = Console.ReadLine();
            Console.WriteLine("Ingrese el ID del Cliente : ");
            int _IdCliente = int.Parse(Console.ReadLine());

            tbTarjeta oTbTarj = new tbTarjeta()
            {
                numeroTarjeta = _NumTarj,
                tipoTarjeta = _tipoTarj,
                modoPago = _ModoPago,
                fechaVencimiento = _FechaVenc,
                idCliente = _IdCliente

            };

            using (var conn = new BD_Practica1EF())
            {
                conn.tbTarjeta.Add(oTbTarj);
                conn.SaveChanges();
            }



        }
        public void ListarTarjeta()
        {
            List<RegistroTarjCli> listaRegTarjeta = new List<RegistroTarjCli>();
            using (var conn = new BD_Practica1EF())
            {
                /*
                select idTarjeta,numeroTarjeta,tipoTarjeta,modoPago,fechaNacimiento,nombreCliente from tbTarjeta inner join tbCliente
                on tbTarjeta.idCliente=tbCliente.idCliente
                 */
                var listaDatosTarjeta = from tarj in conn.tbTarjeta
                                        join cli in conn.tbCliente
                                        on tarj.idCliente equals cli.idCliente

                                        select new RegistroTarjCli
                                        {

                                            NumeroTarjeta = tarj.numeroTarjeta,
                                            TipoTarjeta = tarj.tipoTarjeta,
                                            ModoPago = tarj.modoPago,
                                            FechaVenc = tarj.fechaVencimiento,
                                            NombreCliente =  cli.nombreCliente



                                        };
                listaRegTarjeta = listaDatosTarjeta.ToList();

            }
            Console.WriteLine("\n Lista de Tarjetas ");
            Console.WriteLine("Id Tarjeta \t NUMERO TARJETA Col \t\t TIPO TARJETA \t\t MODO PAGO  \t Fecha VENC \t CLIENTE");
            for (int i = 0; i < listaRegTarjeta.Count; i++)
            {
                Console.WriteLine(listaRegTarjeta[i].IdTarjeta + "\t\t"
                    + listaRegTarjeta[i].NumeroTarjeta + "\t"
                    + listaRegTarjeta[i].TipoTarjeta + "\t\t"
                    + listaRegTarjeta[i].ModoPago + "\t\t"
                    + listaRegTarjeta[i].FechaVenc + "\t\t"
                    + listaRegTarjeta[i].NombreCliente);


            }


        }
    }
}


