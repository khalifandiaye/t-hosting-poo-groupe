using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class HostingDataProvider
    {
        static string connString = ConfigurationManager.ConnectionStrings["THostingDB"].ConnectionString;

        /// <summary>
        /// Récupère les hébergements.
        /// </summary>
        /// <returns>Datatable dtHosting</returns>
        public static DataTable GetHostingList()
        {
            DataTable dtHosting = new DataTable("Hosting");

            using(SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Select * From Hosting";
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dtHosting);
            }

            return dtHosting;
        }

        /// <summary>
        /// Récupère l'hébergement via son id.
        /// </summary>
        /// <param name="idHosting">int idHosting</param>
        /// <returns>DataTable dtHosting</returns>
        public static DataRow GetHosting(int idHosting)
        {
            DataTable dtHosting = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Select * From Hosting Where idHosting=@idHosting";
                cmd.Parameters.AddWithValue("@idHosting", idHosting);

                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dtHosting);
            }

            return dtHosting.Rows[0];
        }

        /// <summary>
        /// Insert un hébergement dans la bd.
        /// </summary>
        /// <param name="nameHosting">string nameHosting</param>
        /// <param name="descriptionHosting">string descriptionHosting</param>
        /// <returns>Boolean</returns>
        public static Boolean InsertHosting(string nameHosting, string descriptionHosting)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Insert into Hosting (nameHosting, descriptionHosting) Values (@nameHosting, @descriptionHosting)";
                cmd.Parameters.AddWithValue("@nameHosting", nameHosting);
                cmd.Parameters.AddWithValue("@descriptionHosting", nameHosting);

                if (cmd.ExecuteNonQuery() == 1)
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// Modifie un hébergement en bd.
        /// </summary>
        /// <param name="idHosting">int idHosting</param>
        /// <param name="nameHosting">string nameHosting</param>
        /// <param name="descriptionHosting">string descriptionHosting</param>
        /// <returns>Boolean</returns>
        public static Boolean UpdateHosting(int idHosting, string nameHosting, string descriptionHosting)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Update Hosting Set nameHosting = @nameHosting, descriptionHosting = @descriptionHosting Where idHosting=@idHosting";
                cmd.Parameters.AddWithValue("@idHosting", idHosting);
                cmd.Parameters.AddWithValue("@nameHosting", nameHosting);
                cmd.Parameters.AddWithValue("@descriptionHosting", descriptionHosting);

                if (cmd.ExecuteNonQuery() == 1)
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// Supprime un hébergement en bd.
        /// </summary>
        /// <param name="idHosting">int idHosting</param>
        /// <returns>Boolean</returns>
        public static Boolean DeleteHosting(int idHosting)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Delete From Hosting Where idHosting=@idHosting";
                cmd.Parameters.AddWithValue("@idHosting", idHosting);

                if (cmd.ExecuteNonQuery() == 1)
                    return true;
                else
                    return false;
            } 
        }
    }
}
