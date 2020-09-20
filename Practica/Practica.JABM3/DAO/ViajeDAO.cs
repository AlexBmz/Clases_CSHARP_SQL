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
   public  class ViajeDAO
    {
        #region CadenaConexion

        string _StringConnection = ConfigurationManager.ConnectionStrings["connexionBD"].ConnectionString;

        #endregion CadenaConexion

        //public List<ViajeBEAN> Registro_Y_Listado_Viaje(ViajeBEAN listViaje)
        //{
        //    List<ViajeBEAN> listaViaj = new List<ViajeBEAN>();
        //    ViajeBEAN oViajeBean;
        //    try
        //    {
        //        using (var con = new SqlConnection(_StringConnection))
        //        {
        //            using (var cmd = new SqlCommand("sp_Viaje_Registrar_Listar", con))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.AddWithValue("@idTarjeta", );
        //                con.Open();
        //                using (var dr = cmd.ExecuteReader())
        //                {
        //                    while (dr.Read())
        //                    {
        //                        oViajeBean = new ViajeBEAN();
        //                        oViajeBean.IdTarjeta = Convert.ToInt32(dr[0]);
        //                        oViajeBean.IdPais = Convert.ToInt32(dr[1]);
        //                        oViajeBean.FechaInicio=Convert.ToDateTime(dr[2]);
        //                        oViajeBean.FechaFin = Convert.ToDateTime(dr[3]);
        //                        oViajeBean.EstadoViaje = Convert.ToString(dr[4]);
        //                        listaViaj.Add(oViajeBean);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //    return listaViaj;
        //}
        public List<ViajeBEAN> Registro_Y_Listado_Viaje(int idTarj,int idPais, DateTime fechaIni,DateTime fechaFin)
        {
            List<ViajeBEAN> listaViaje = new List<ViajeBEAN>();
            ViajeBEAN oViaje;
            try
            {
                using (var conn = new SqlConnection(_StringConnection))
                {
                    using (var cmd = new SqlCommand("sp_Viaje_Registrar_Listar", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idTarjeta",idTarj);
                        cmd.Parameters.AddWithValue("@idPais", idPais);
                        cmd.Parameters.AddWithValue("@fechaIni", fechaIni);
                        cmd.Parameters.AddWithValue("@fechaFin", fechaFin);
                       // cmd.Parameters.AddWithValue("@estadoViaje", estadoViaje);
                        conn.Open();
                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                oViaje = new ViajeBEAN();
                                oViaje.IdTarjeta = Convert.ToInt32(dr[0]);
                                oViaje.IdPais = Convert.ToInt32(dr[1]);
                                oViaje.FechaInicio = Convert.ToDateTime(dr[2]);
                                oViaje.FechaFin = Convert.ToDateTime(dr[3]);
                               // oViaje.EstadoViaje = Convert.ToString(dr[4]);

                                listaViaje.Add(oViaje);
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return listaViaje;
        }


        public List<ViajeBEAN> listaViaje()
        {
            List<ViajeBEAN> listaCol = new List<ViajeBEAN>();
            ViajeBEAN oViajeBean;
            try
            {
                using (var conn = new SqlConnection(_StringConnection))
                {
                    using (var cmd = new SqlCommand("sp_Viaje_List", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                oViajeBean = new ViajeBEAN();                               
                                oViajeBean.IdViaje = Convert.ToInt32(dr[0]);
                                oViajeBean.numTarjeta = Convert.ToString(dr[1]);
                                oViajeBean.TipoTarj = Convert.ToString(dr[2]);
                                oViajeBean.nombrePais = Convert.ToString(dr[3]);                             
                                oViajeBean.FechaInicio = Convert.ToDateTime(dr[4]);
                                oViajeBean.FechaFin = Convert.ToDateTime(dr[5]);

                                listaCol.Add(oViajeBean);
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return listaCol;
        }

    }
    
}
