using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BU
{
    public class OfferManager
    {
        /// <summary>
        /// Récupère une offre via l'id de son hébergement.
        /// </summary>
        /// <param name="idHosting">idHosting</param>
        /// <returns>DataTable</returns>
        public static DataTable GetOfferByHosting(int idHosting)
        {
            return DAL.OfferDataProvider.GetOfferByHosting(idHosting);
        }

        /// <summary>
        /// Récupère une offre via son id.
        /// </summary>
        /// <param name="idOffer">int idOffer</param>
        /// <returns>Offer</returns>
        public static Entities.Offer GetOffer(int idOffer)
        {
            DataRow drOffer = DAL.OfferDataProvider.GetOffer(idOffer);
            Entities.Offer offer = new Entities.Offer();

            if (drOffer != null)
            {
                offer.idOffer = (int)drOffer["idOffer"];
                offer.idHosting = HostingManager.GetHosting((int)drOffer["idHosting"]);
                offer.nameOffer = drOffer["nameOffer"].ToString();
                offer.descriptionOffer = drOffer["descriptionOffer"].ToString();
                offer.cpu = drOffer["cpu"].Equals(DBNull.Value) ? null : drOffer["cpu"].ToString();
                offer.ram = drOffer["ram"].Equals(DBNull.Value) ? 0 : (int)drOffer["ram"];
                offer.hdd = drOffer["hdd"].Equals(DBNull.Value) ? null : drOffer["hdd"].ToString();
                offer.spaceDisk = drOffer["spaceDisk"].Equals(DBNull.Value) ? 0 : (int)drOffer["spaceDisk"];
                offer.raid = drOffer["raid"].Equals(DBNull.Value) ? null : drOffer["raid"].ToString();
                offer.bandWidth = drOffer["bandwidth"].Equals(DBNull.Value) ? 0 : (int)drOffer["bandwidth"];
                offer.trafic = drOffer["trafic"].Equals(DBNull.Value) ? 0 : (int)drOffer["trafic"];
                offer.price = (decimal)drOffer["price"];

                return offer;
            }
            else
                return null;
        }
    }
}
