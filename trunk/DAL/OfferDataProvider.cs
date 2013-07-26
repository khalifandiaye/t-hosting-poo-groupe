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
    public class OfferDataProvider
    {
        static string connString = ConfigurationManager.ConnectionStrings["THostingDB"].ConnectionString;

        /// <summary>
        /// Récupère l'offre via son id.
        /// </summary>
        /// <param name="idOffer">int idOffer</param>
        /// <returns>DataTable dtOffer</returns>
        public static DataRow GetOffer(int idOffer)
        {
            DataTable dtOffer = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Select * from Offer Where idOffer=@idOffer";
                cmd.Parameters.AddWithValue("@idOffer", idOffer);

                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dtOffer);

            }

            if (dtOffer.Rows.Count > 0)
                return dtOffer.Rows[0];
            else
                return null;             
        }

        /// <summary>
        /// Récupère les offres pour l'hébergement passé en paramètre
        /// </summary>
        /// <param name="idHosting">int idHosting</param>
        /// <returns>DataTable dtOffer</returns>
        public static DataTable GetOfferByHosting(int idHosting)
        {
            DataTable dtOffer = new DataTable("Offer");

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Select * from Offer Where idHosting=@idHosting";
                cmd.Parameters.AddWithValue("@idHosting",idHosting);

                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dtOffer);

            }

            return dtOffer;
        }

        /// <summary>
        /// Méthode d'insertion d'une offre en bd.
        /// </summary>
        /// <param name="idHosting">int idHosting</param>
        /// <param name="nameOffer">string nameOffer</param>
        /// <param name="descriptionOffer">string descriptionOffer</param>
        /// <param name="cpu">string cpu</param>
        /// <param name="ram">int ram</param>
        /// <param name="hdd">string hdd</param>
        /// <param name="spaceDisk">int spaceDisk</param>
        /// <param name="raid">string raid</param>
        /// <param name="bandwidth">int bandwidth</param>
        /// <param name="trafic">int trafic</param>
        /// <param name="price">decimal price</param>
        /// <returns>Boolean</returns>
        public static Boolean InsertOffer(int idHosting, string nameOffer, string descriptionOffer, string cpu, int ram, string hdd, int spaceDisk, string raid, int bandwidth, int trafic, decimal price)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Insert Into Offer (idHosting, nameOffer, descriptionOffer, cpu, ram, hdd, spaceDisk, raid, bandwidth, trafic, price) Values (@idHosting, @nameOffer, @descriptionOffer, @cpu, @ram, @hdd, @spaceDisk, @raid, @bandwidth, @trafic, @price)";
                cmd.Parameters.AddWithValue("@idHosting", idHosting);
                cmd.Parameters.AddWithValue("@nameOffer", nameOffer);
                cmd.Parameters.AddWithValue("@descriptionOffer", descriptionOffer);
                cmd.Parameters.AddWithValue("@cpu", cpu);
                cmd.Parameters.AddWithValue("@ram", ram);
                cmd.Parameters.AddWithValue("@hdd", hdd);
                cmd.Parameters.AddWithValue("@spaceDisk", spaceDisk);
                cmd.Parameters.AddWithValue("@raid", raid);
                cmd.Parameters.AddWithValue("@bandwidth", bandwidth);
                cmd.Parameters.AddWithValue("@trafic", trafic);
                cmd.Parameters.AddWithValue("@price", price);

                if (cmd.ExecuteNonQuery() == 1)
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// Méthode de modification d'une offre en bd.
        /// </summary>
        /// <param name="idOffer">int idOffer</param>
        /// <param name="idHosting">int idHosting</param>
        /// <param name="nameOffer">string nameOffer</param>
        /// <param name="descriptionOffer">string descriptionOffer</param>
        /// <param name="cpu">string cpu</param>
        /// <param name="ram">int ram</param>
        /// <param name="hdd">string hdd</param>
        /// <param name="spaceDisk">int spaceDisk</param>
        /// <param name="raid">string raid</param>
        /// <param name="bandwidth">int bandwidth</param>
        /// <param name="trafic">int trafic</param>
        /// <param name="price">decimal price</param>
        /// <returns>Boolean</returns>
        public static Boolean UpdateOffer(int idOffer, int idHosting, string nameOffer, string descriptionOffer, string cpu, int ram, string hdd, int spaceDisk, string raid, int bandwidth, int trafic, decimal price)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Update Offer Set idHosting=@idHosting, nameOffer=@nameOffer, descriptionOffer=@descriptionOffer, cpu=@cpu, ram=@ram, hdd=@hdd, spaceDisk=@spaceDisk, raid=@raid, bandwidth=@bandwidth, trafic=@trafic, price=@price Where idOffer=@idOffer";
                cmd.Parameters.AddWithValue("@idOffer", idOffer);
                cmd.Parameters.AddWithValue("@idHosting", idHosting);
                cmd.Parameters.AddWithValue("@nameOffer", nameOffer);
                cmd.Parameters.AddWithValue("@descriptionOffer", descriptionOffer);
                cmd.Parameters.AddWithValue("@cpu", cpu);
                cmd.Parameters.AddWithValue("@ram", ram);
                cmd.Parameters.AddWithValue("@hdd", hdd);
                cmd.Parameters.AddWithValue("@spaceDisk", spaceDisk);
                cmd.Parameters.AddWithValue("@raid", raid);
                cmd.Parameters.AddWithValue("@bandwidth", bandwidth);
                cmd.Parameters.AddWithValue("@trafic", trafic);
                cmd.Parameters.AddWithValue("@price", price);

                if (cmd.ExecuteNonQuery() == 1)
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// Permet de supprimer une offre via son id.
        /// </summary>
        /// <param name="idOffer">int idOffer</param>
        /// <returns>Boolean</returns>
        public static Boolean DeleteOffer(int idOffer)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Delete from Offer Where idOffer=@idOffer";
                cmd.Parameters.AddWithValue("@idoffer", idOffer);

                if (cmd.ExecuteNonQuery() >= 1)
                    return true;
                else
                    return false;
            }
        }

    }
}
