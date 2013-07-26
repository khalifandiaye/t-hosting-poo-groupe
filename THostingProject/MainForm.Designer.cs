namespace THostingProject
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.offreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOfferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateOfferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteOfferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.offreToolStripMenuItem,
            this.commandeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(566, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // offreToolStripMenuItem
            // 
            this.offreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOfferToolStripMenuItem,
            this.updateOfferToolStripMenuItem,
            this.deleteOfferToolStripMenuItem});
            this.offreToolStripMenuItem.Name = "offreToolStripMenuItem";
            this.offreToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.offreToolStripMenuItem.Text = "Offre";
            // 
            // newOfferToolStripMenuItem
            // 
            this.newOfferToolStripMenuItem.Name = "newOfferToolStripMenuItem";
            this.newOfferToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.newOfferToolStripMenuItem.Text = "Nouvelle offre";
            this.newOfferToolStripMenuItem.Click += new System.EventHandler(this.newOfferToolStripMenuItem_Click);
            // 
            // updateOfferToolStripMenuItem
            // 
            this.updateOfferToolStripMenuItem.Name = "updateOfferToolStripMenuItem";
            this.updateOfferToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.updateOfferToolStripMenuItem.Text = "Modifier offre";
            this.updateOfferToolStripMenuItem.Click += new System.EventHandler(this.updateOfferToolStripMenuItem_Click);
            // 
            // deleteOfferToolStripMenuItem
            // 
            this.deleteOfferToolStripMenuItem.Name = "deleteOfferToolStripMenuItem";
            this.deleteOfferToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.deleteOfferToolStripMenuItem.Text = "Suppression offre";
            this.deleteOfferToolStripMenuItem.Click += new System.EventHandler(this.deleteOfferToolStripMenuItem_Click);
            // 
            // commandeToolStripMenuItem
            // 
            this.commandeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOrderToolStripMenuItem});
            this.commandeToolStripMenuItem.Name = "commandeToolStripMenuItem";
            this.commandeToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.commandeToolStripMenuItem.Text = "Commande";
            // 
            // newOrderToolStripMenuItem
            // 
            this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.newOrderToolStripMenuItem.Text = "Nouvelle commande";
            this.newOrderToolStripMenuItem.Click += new System.EventHandler(this.newOrderToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 308);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 457);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "T-Hosting Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem offreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newOfferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateOfferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteOfferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

