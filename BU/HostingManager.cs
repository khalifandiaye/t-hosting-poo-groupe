using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BU
{
    public class HostingManager
    {
        /// <summary>
        /// Récupère la liste des hébergements sous la forme d'une datatable.
        /// </summary>
        /// <returns>DataTable</returns>
        public static DataTable GetHostingList()
        {
            return DAL.HostingDataProvider.GetHostingList();
        }

        /// <summary>
        /// Récupére un hébergement via son id. Retourne un objet hosting, mappé à la bd.
        /// </summary>
        /// <param name="idHosting">int idHosting</param>
        /// <returns>Hosting</returns>
        public static Entities.Hosting GetHosting(int idHosting)
        {
            DataRow drHosting = DAL.HostingDataProvider.GetHosting(idHosting);
            Entities.Hosting hosting = new Entities.Hosting();

            if (drHosting != null)
            {
                hosting.idHosting = (int)drHosting["idHosting"];
                hosting.nameHosting = drHosting["nameHosting"].ToString();
                hosting.descriptionHosting = drHosting["descriptionHosting"].ToString();

                return hosting;
            }
            else
                return null;
        }
    }
}
