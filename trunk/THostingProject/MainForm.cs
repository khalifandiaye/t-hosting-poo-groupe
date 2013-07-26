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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void newOfferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Offer newOffer = new Offer("Nouvelle offre");
            newOffer.ShowDialog();
        }

        private void updateOfferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Offer updateOffer = new Offer("Modifier l'offre", "Modifier");
            updateOffer.ShowDialog();
        }

        private void deleteOfferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Offer deleteOffer = new Offer("Supprimer l'offre", "Supprimer", "");
            deleteOffer.ShowDialog();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }


}
