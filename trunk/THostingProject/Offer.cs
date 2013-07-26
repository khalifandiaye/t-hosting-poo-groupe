using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace THostingProject
{
    public partial class Offer : Form
    {
        //DataSet ds;
        BU.Entities.Offer offer;
        public Offer()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        /// <summary>
        /// Constructeur avec paramètres pour "nouvelle offre".
        /// </summary>
        /// <param name="labelOffer">string labelOffer</param>
        public Offer(string labelOffer)
        {
            InitializeComponent();
            this.CenterToParent();
            CB_NameTypeHosting.Text = string.Empty;
            PopulateTypeHosting();
            labelO.Text = labelOffer;
            button1.Text = "Créer";
            //TB_SpaceDiskOffer.Enabled = false;
            //TB_TraficOffer.Enabled = false;
            DisableTxtBox();
            labelCBNameOffer.Visible = false;
            CB_NameOffer.Visible = false;
            

        }


        /// <summary>
        /// Constructeur avec paramètres pour "modifier offre".
        /// </summary>
        /// <param name="labelOffer"></param>
        /// <param name="buttonValid"></param>
        public Offer(string labelOffer, string buttonValid)
        {
            InitializeComponent();
            this.CenterToParent();
            PopulateTypeHosting();
            labelO.Text = labelOffer;
            button1.Text = buttonValid;
            labelNameOffer.Text = "Nouveau nom de l'offre:";
           

        }

        /// <summary>
        /// Constructeur avec paramètres pour suppression offre.
        /// </summary>
        /// <param name="labelOffer">string labelOffer</param>
        /// <param name="buttonValid">string buttonValid</param>
        /// <param name="descriptionOffre">string descriptionOffer</param>
        public Offer(string labelOffer, string buttonValid, string descriptionOffer)
        {
            InitializeComponent();
            this.CenterToParent();
            labelO.Text = labelOffer;
            button1.Text = buttonValid;
            PopulateTypeHosting();
            DisableTxtBox();
        }

        /// <summary>
        /// Rempli une combobox avec les différents types d'hébergement.
        /// </summary>
        private void PopulateTypeHosting()
        {
            //ds = new DataSet();

            //DataTable dtHosting = new DataTable();
            //dtHosting = BU.HostingManager.GetHostingList();
            //ds.Tables.Add(dtHosting);

            CB_NameTypeHosting.DataSource = BU.HostingManager.GetHostingList();
            CB_NameTypeHosting.DisplayMember = "nameHosting";
            CB_NameTypeHosting.ValueMember = "idHosting";

            //DataTable dtOffer = new DataTable();
            //dtOffer = BU.OfferManager.GetOfferByHosting((int)CB_NameTypeHosting.SelectedValue);
            //ds.Tables.Add(dtOffer);
            
        }

        /// <summary>
        /// Rempli une combobox avec les différents types d'offres
        /// </summary>
        /// <param name="idHosting">int idHosting</param>
        private void PopulateNameOffer(int idHosting)
        {
            CB_NameOffer.DataSource = BU.OfferManager.GetOfferByHosting(idHosting);
            CB_NameOffer.DisplayMember = "nameOffer";
            CB_NameOffer.ValueMember = "idOffer";
        }

        private void CB_NameTypeHosting_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Récupère l'id de l'hébergement que l'utilisateur a choisi.
            int idSelectedItem = Int32.Parse(((DataRowView)CB_NameTypeHosting.SelectedItem).Row["idHosting"].ToString());
            PopulateNameOffer(idSelectedItem);

            //Si c'est un serveur dédié ou virtualisé
            if (labelO.Text.Equals("Nouvelle offre") && (idSelectedItem == 1 || idSelectedItem == 2))
            {
                TB_NameOffer.Enabled = true;
                TB_NameOffer.Clear();
                TB_DescriptOffer.Enabled = true;
                TB_DescriptOffer.Clear();
                TB_CpuOffer.Enabled = true;
                TB_CpuOffer.Clear();
                TB_RamOffer.Enabled = true;
                TB_RamOffer.Clear();
                TB_Hdd.Enabled = true;
                TB_Hdd.Clear();
                TB_SpaceDiskOffer.Enabled = false;
                TB_RaidOffer.Enabled = true;
                TB_RaidOffer.Clear();
                TB_BandwidthOffer.Enabled = true;
                TB_BandwidthOffer.Clear();
                TB_TraficOffer.Enabled = false;
                TB_PriceOffer.Enabled = true;
                TB_PriceOffer.Clear();               
            }
            //Si c'est un serveur mutualisé
           if (labelO.Text.Equals("Nouvelle offre") && idSelectedItem == 3)
            {
                TB_NameOffer.Enabled = false;
                TB_NameOffer.Clear();
                TB_DescriptOffer.Enabled = true;
                TB_DescriptOffer.Clear();
                TB_CpuOffer.Enabled = false;
                TB_RamOffer.Enabled = false;
                TB_Hdd.Enabled = false;
                TB_SpaceDiskOffer.Enabled = true;
                TB_SpaceDiskOffer.Clear();
                TB_RaidOffer.Enabled = false;
                TB_BandwidthOffer.Enabled = false;
                TB_TraficOffer.Enabled = true;
                TB_TraficOffer.Clear();
                TB_PriceOffer.Enabled = true;
                TB_PriceOffer.Clear();  
            }
        }

        private void CB_NameOffer_SelectedIndexChanged(object sender, EventArgs e)
        {

            int idSelectedItem = Int32.Parse(((DataRowView)CB_NameOffer.SelectedItem).Row["idOffer"].ToString());
            int idTypehosting = Int32.Parse(((DataRowView)CB_NameTypeHosting.SelectedItem).Row["idHosting"].ToString());
            offer = BU.OfferManager.GetOffer(idSelectedItem);

            if (labelO.Text.Equals("Modifier l'offre") && (idTypehosting == 1 || idTypehosting == 2))
            {
                TB_NameOffer.Text = offer.nameOffer;
                TB_DescriptOffer.Text = offer.descriptionOffer;
                TB_CpuOffer.Text = offer.cpu;
                TB_RamOffer.Text = offer.ram.ToString();
                TB_Hdd.Text = offer.hdd;
                TB_SpaceDiskOffer.Enabled = false;
                TB_RaidOffer.Text = offer.raid;
                TB_BandwidthOffer.Text = offer.bandWidth.ToString();
                TB_TraficOffer.Enabled = false;
                TB_PriceOffer.Text = offer.price.ToString();
            }
            if (labelO.Text.Equals("Modifier l'offre") && idTypehosting == 3)
            {
                TB_NameOffer.Text = offer.nameOffer;
                TB_DescriptOffer.Text = offer.descriptionOffer;
                TB_CpuOffer.Enabled = false;
                TB_RamOffer.Enabled = false;
                TB_Hdd.Enabled = false;
                TB_SpaceDiskOffer.Text = offer.spaceDisk.ToString();
                TB_RaidOffer.Enabled = false;
                TB_BandwidthOffer.Enabled = false;
                TB_TraficOffer.Text = offer.trafic.ToString();
                TB_PriceOffer.Text = offer.price.ToString();

            }
                
        }
        /// <summary>
        /// Méthode qui grise les txtbox pour nouvelle/suppression offre
        /// </summary>
        private void DisableTxtBox()
        {
            TB_NameOffer.Enabled = false;
            TB_DescriptOffer.Enabled = false;
            TB_CpuOffer.Enabled = false;
            TB_RamOffer.Enabled = false;
            TB_Hdd.Enabled = false;
            TB_SpaceDiskOffer.Enabled = false;
            TB_RaidOffer.Enabled = false;
            TB_BandwidthOffer.Enabled = false;
            TB_TraficOffer.Enabled = false;
            TB_PriceOffer.Enabled = false;
        }
        


    }
}
