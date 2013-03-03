using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace exercice_mode_deconnecte_25102012
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["NorthwindDB"].ConnectionString;
            DataSet ds = new DataSet(); 
            DisplayCategory(connString,ds);
            SelectCategory(connString, ds);
            Console.ReadLine();
        }

        static void DisplayCategory(string connString, DataSet ds)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();

                OleDbDataAdapter adpt = new OleDbDataAdapter("SELECT * FROM Categories", conn);
                
                adpt.Fill(ds, "Categories");
            }

            DataTable categorieDT = ds.Tables["Categories"];

            DataRow firstCategoryRow = categorieDT.Rows[0];

            string firstCategoryName = (string)firstCategoryRow["CategoryName"];

            foreach (DataRow categoryRow in categorieDT.Rows)
            {

                Console.WriteLine(categoryRow["CategoryID"] + " " + categoryRow["CategoryName"]);

            }


        }

        static void SelectCategory(string connString, DataSet ds)
        {
            
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();

                OleDbDataAdapter adpt = new OleDbDataAdapter("SELECT * FROM Categories", conn);

                adpt.Fill(ds, "Categories");
            }

            Console.WriteLine("Quelle catégorie choisissez-vous?");
            string categoryChoice = Console.ReadLine();
            int idCategory;
            if (!int.TryParse(categoryChoice, out idCategory))
            {
                Console.WriteLine("Ceci n'est pas une catégorie valide");
                return;
            }
            else
            {
                DataTable produitDT = ds.Tables["Products"];

                DataRow firstProductRow = produitDT.Rows[0];

                string firstProductName = (string)firstProductRow["ProductName"];

                foreach (DataRow productRow in produitDT.Rows)
                {

                    Console.WriteLine(productRow["ProductID"] + " " + productRow["ProductName"] + " " + productRow["UnitPrice"] + " " + productRow["UnitsInStock"]);

                }
            }
            
        }
    }
}
