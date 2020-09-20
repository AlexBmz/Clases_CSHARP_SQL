using Practica1.CosolApp1JABM.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.CosolApp1JABM
{
   public  class PaisDAO
    {
        public void RegistrarPais()
        {
            Console.Write("Ingrese el  nombre Pais : ");
            string _Pais = Console.ReadLine();
            Console.Write("Ingrese Codigo de Pais : ");
            string _CodPais = Console.ReadLine();
           
            tbPais oTbPais = new tbPais()
            {
                nombrePais = _Pais,
                codigoPais = _CodPais
            };


            using (var conn = new BD_Practica1EF())
            {
                conn.tbPais.Add(oTbPais);
                conn.SaveChanges();
            }

            Console.WriteLine("Registro correctamente");


        }

        public void ListarPais()
        {

            List<tbPais> listaPais = new List<tbPais>();

            using (var conn = new BD_Practica1EF())
            {
                //Obtener la información desde EF
                listaPais = conn.tbPais.ToList();
            }
            for (int i = 0; i < listaPais.Count; i++)
            {
                Console.WriteLine(listaPais[i].idPais + "-" + listaPais[i].nombrePais + "-" + listaPais[i].codigoPais);
                
            }


        }

        public void ActualizarPais()
        {
            Console.Write("Ingrese el Id del Pais a Actualizar : ");
            int idPais = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el Nombre nuevo  del Pais a Actualizar  : ");
            string nombPais = Console.ReadLine();
            Console.Write("Ingrese el Codigo nuevo  del Pais a Actualizar  : ");
            string codPais = Console.ReadLine();
          
            using (var conn = new BD_Practica1EF())
            {
                tbPais pa = conn.tbPais.Find(idPais);
                pa.nombrePais = nombPais;
                pa.codigoPais = codPais;         
                conn.SaveChanges();
            }

        }
    }
}
