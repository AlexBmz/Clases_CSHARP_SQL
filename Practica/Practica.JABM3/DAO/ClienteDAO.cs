using Practica.JABM3.BEAN;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.JABM3.DAO
{
    class ClienteDAO
    {
        #region CadenaConexion

        string _StringConnection = ConfigurationManager.ConnectionStrings["connexionBD"].ConnectionString;

        #endregion CadenaConexion

        public List<ClienteBEAN> ListClientes()
        {
            List<ClienteBEAN> lista = new List<ClienteBEAN>();
            ClienteBEAN cli;
            try
            {

                using (var conn = new SqlConnection(_StringConnection))
                {
                    using (var cmd = new SqlCommand("sp_Cliente_List", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                cli = new ClienteBEAN();
                                cli.IdCliente = Convert.ToInt32(dr[0]);
                                cli.NombreCliente = Convert.ToString(dr[1]);
                                cli.ApellidoCliente = Convert.ToString(dr[2]);
                                cli.FechaNacimiento = Convert.ToDateTime(dr[3]);
                                cli.Dni = Convert.ToString(dr[4]);
                              
                                lista.Add(cli);

                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return lista;
        }


    }
}
