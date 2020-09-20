using Practica1.CosolApp1JABM.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.CosolApp1JABM
{
    public class ClienteDAO
    {
        public void RegistrarCliente()
        {
            Console.Write("Ingrese el  nombre Cliente : ");
            string _nombreCli = Console.ReadLine();
            Console.Write("Ingrese apellido del Cliente");
            string _apeCliente = Console.ReadLine();
            Console.Write("Ingrese la Fecha de Nacimiento : ");
            DateTime _fechaNac = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Ingrese el Dni del Cliente : ");
            string _Dni = Console.ReadLine();
            tbCliente oTbCli = new tbCliente()
            {
                nombreCliente = _nombreCli,
                apellidosCliente = _apeCliente,
                fechaNacimiento = _fechaNac,
                dniCliente = _Dni

            };


            using (var conn = new BD_Practica1EF())
            {
                conn.tbCliente.Add(oTbCli);
                conn.SaveChanges();
            }

            Console.WriteLine("Registro correctamente");


        }

        public void ListarCliente()
        {

            List<tbCliente> listaCli = new List<tbCliente>();

            using (var conn = new BD_Practica1EF())
            {
                //Obtener la información desde EF
                listaCli = conn.tbCliente.ToList();
            }
            for (int i = 0; i < listaCli.Count; i++)
            {
                Console.WriteLine(listaCli[i].idCliente + "-" + listaCli[i].nombreCliente
                    + "-" + listaCli[i].apellidosCliente + "-" + listaCli[i].fechaNacimiento
                    + "-" + listaCli[i].dniCliente);
            }


        }

        public void ActualizarCliente()
        {
            Console.Write("Ingrese el Id del Cliente a Actualizar : ");
            int idCli = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el Nombre nuevo  del Cliente a Actualizar  : ");
            string nombreCli = Console.ReadLine();
            Console.Write("Ingrese el Apellido nuevo  del Cliente a Actualizar  : ");
            string apeCli = Console.ReadLine();
            Console.Write("Ingrese la fecha de Nacimiento a Actualizar :");
            DateTime fechaCli = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Ingrese el Dni Del cliente a Actualizar : ");
            String DniCli = Console.ReadLine();

            using (var conn = new BD_Practica1EF())
            {
                tbCliente cli = conn.tbCliente.Find(idCli);
                cli.nombreCliente = nombreCli;
                cli.apellidosCliente = apeCli;
                cli.fechaNacimiento = fechaCli;
                cli.dniCliente = DniCli;
                conn.SaveChanges();
            }

        }
    }
}
