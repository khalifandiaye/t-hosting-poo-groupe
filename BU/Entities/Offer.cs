using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BU.Entities
{
    public class Offer
    {
        public int idOffer { get; set; }

        public Entities.Hosting idHosting { get; set; }

        public string nameOffer { get; set; }
        
        public string descriptionOffer { get; set; }

        public string cpu { get; set; }

        public int ram { get; set; }

        public string hdd { get; set; }

        public int spaceDisk { get; set; }

        public string raid { get; set; }

        public int bandWidth { get; set; }

        public int trafic { get; set; }

        public decimal price { get; set; }
    }
}
