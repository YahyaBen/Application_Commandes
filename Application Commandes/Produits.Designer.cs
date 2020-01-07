namespace Application_Commandes
{
    partial class Produits
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DGV_Produit = new System.Windows.Forms.DataGridView();
            this.Txt_ProID = new System.Windows.Forms.TextBox();
            this.Txt_ProLibelle = new System.Windows.Forms.TextBox();
            this.Txt_ProPu = new System.Windows.Forms.TextBox();
            this.Txt_ProRechercher = new System.Windows.Forms.TextBox();
            this.CB_ProCategories = new System.Windows.Forms.ComboBox();
            this.Btn_ProAjouter = new System.Windows.Forms.Button();
            this.Btn_ProModifier = new System.Windows.Forms.Button();
            this.Btn_ProSupprimer = new System.Windows.Forms.Button();
            this.Btn_ProFermer = new System.Windows.Forms.Button();
            this.ProProduit = new System.Windows.Forms.GroupBox();
            this.ProInformations = new System.Windows.Forms.GroupBox();
            this.Txt_ProNbrCommande = new System.Windows.Forms.TextBox();
            this.Txt_ProCA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Produit)).BeginInit();
            this.ProProduit.SuspendLayout();
            this.ProInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Libelle :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categories :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Recherche :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nbr Commandes :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "CA :";
            // 
            // DGV_Produit
            // 
            this.DGV_Produit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Produit.Location = new System.Drawing.Point(25, 44);
            this.DGV_Produit.Name = "DGV_Produit";
            this.DGV_Produit.Size = new System.Drawing.Size(463, 154);
            this.DGV_Produit.TabIndex = 9;
            // 
            // Txt_ProID
            // 
            this.Txt_ProID.Enabled = false;
            this.Txt_ProID.Location = new System.Drawing.Point(98, 20);
            this.Txt_ProID.Name = "Txt_ProID";
            this.Txt_ProID.Size = new System.Drawing.Size(191, 20);
            this.Txt_ProID.TabIndex = 10;
            // 
            // Txt_ProLibelle
            // 
            this.Txt_ProLibelle.Location = new System.Drawing.Point(98, 49);
            this.Txt_ProLibelle.Name = "Txt_ProLibelle";
            this.Txt_ProLibelle.Size = new System.Drawing.Size(191, 20);
            this.Txt_ProLibelle.TabIndex = 11;
            // 
            // Txt_ProPu
            // 
            this.Txt_ProPu.Location = new System.Drawing.Point(98, 75);
            this.Txt_ProPu.Name = "Txt_ProPu";
            this.Txt_ProPu.Size = new System.Drawing.Size(191, 20);
            this.Txt_ProPu.TabIndex = 12;
            // 
            // Txt_ProRechercher
            // 
            this.Txt_ProRechercher.Location = new System.Drawing.Point(99, 19);
            this.Txt_ProRechercher.Name = "Txt_ProRechercher";
            this.Txt_ProRechercher.Size = new System.Drawing.Size(191, 20);
            this.Txt_ProRechercher.TabIndex = 13;
            // 
            // CB_ProCategories
            // 
            this.CB_ProCategories.FormattingEnabled = true;
            this.CB_ProCategories.Location = new System.Drawing.Point(98, 102);
            this.CB_ProCategories.Name = "CB_ProCategories";
            this.CB_ProCategories.Size = new System.Drawing.Size(191, 21);
            this.CB_ProCategories.TabIndex = 14;
            // 
            // Btn_ProAjouter
            // 
            this.Btn_ProAjouter.Location = new System.Drawing.Point(320, 28);
            this.Btn_ProAjouter.Name = "Btn_ProAjouter";
            this.Btn_ProAjouter.Size = new System.Drawing.Size(75, 23);
            this.Btn_ProAjouter.TabIndex = 15;
            this.Btn_ProAjouter.Text = "Ajouter";
            this.Btn_ProAjouter.UseVisualStyleBackColor = true;
            // 
            // Btn_ProModifier
            // 
            this.Btn_ProModifier.Location = new System.Drawing.Point(320, 64);
            this.Btn_ProModifier.Name = "Btn_ProModifier";
            this.Btn_ProModifier.Size = new System.Drawing.Size(75, 23);
            this.Btn_ProModifier.TabIndex = 16;
            this.Btn_ProModifier.Text = "Modifier";
            this.Btn_ProModifier.UseVisualStyleBackColor = true;
            // 
            // Btn_ProSupprimer
            // 
            this.Btn_ProSupprimer.Location = new System.Drawing.Point(320, 99);
            this.Btn_ProSupprimer.Name = "Btn_ProSupprimer";
            this.Btn_ProSupprimer.Size = new System.Drawing.Size(75, 23);
            this.Btn_ProSupprimer.TabIndex = 17;
            this.Btn_ProSupprimer.Text = "Supprimer";
            this.Btn_ProSupprimer.UseVisualStyleBackColor = true;
            // 
            // Btn_ProFermer
            // 
            this.Btn_ProFermer.Location = new System.Drawing.Point(497, 76);
            this.Btn_ProFermer.Name = "Btn_ProFermer";
            this.Btn_ProFermer.Size = new System.Drawing.Size(75, 58);
            this.Btn_ProFermer.TabIndex = 18;
            this.Btn_ProFermer.Text = "Fermer";
            this.Btn_ProFermer.UseVisualStyleBackColor = true;
            // 
            // ProProduit
            // 
            this.ProProduit.Controls.Add(this.CB_ProCategories);
            this.ProProduit.Controls.Add(this.label1);
            this.ProProduit.Controls.Add(this.Btn_ProSupprimer);
            this.ProProduit.Controls.Add(this.label2);
            this.ProProduit.Controls.Add(this.Btn_ProModifier);
            this.ProProduit.Controls.Add(this.label3);
            this.ProProduit.Controls.Add(this.Btn_ProAjouter);
            this.ProProduit.Controls.Add(this.label4);
            this.ProProduit.Controls.Add(this.Txt_ProID);
            this.ProProduit.Controls.Add(this.Txt_ProLibelle);
            this.ProProduit.Controls.Add(this.Txt_ProPu);
            this.ProProduit.Location = new System.Drawing.Point(31, 12);
            this.ProProduit.Name = "ProProduit";
            this.ProProduit.Size = new System.Drawing.Size(423, 148);
            this.ProProduit.TabIndex = 19;
            this.ProProduit.TabStop = false;
            this.ProProduit.Text = "Produit";
            // 
            // ProInformations
            // 
            this.ProInformations.Controls.Add(this.Txt_ProCA);
            this.ProInformations.Controls.Add(this.Txt_ProNbrCommande);
            this.ProInformations.Controls.Add(this.DGV_Produit);
            this.ProInformations.Controls.Add(this.label5);
            this.ProInformations.Controls.Add(this.label9);
            this.ProInformations.Controls.Add(this.Txt_ProRechercher);
            this.ProInformations.Controls.Add(this.label8);
            this.ProInformations.Location = new System.Drawing.Point(31, 180);
            this.ProInformations.Name = "ProInformations";
            this.ProInformations.Size = new System.Drawing.Size(567, 258);
            this.ProInformations.TabIndex = 20;
            this.ProInformations.TabStop = false;
            this.ProInformations.Text = "Information";
            // 
            // Txt_ProNbrCommande
            // 
            this.Txt_ProNbrCommande.Enabled = false;
            this.Txt_ProNbrCommande.Location = new System.Drawing.Point(119, 208);
            this.Txt_ProNbrCommande.Name = "Txt_ProNbrCommande";
            this.Txt_ProNbrCommande.Size = new System.Drawing.Size(191, 20);
            this.Txt_ProNbrCommande.TabIndex = 14;
            // 
            // Txt_ProCA
            // 
            this.Txt_ProCA.Enabled = false;
            this.Txt_ProCA.Location = new System.Drawing.Point(119, 234);
            this.Txt_ProCA.Name = "Txt_ProCA";
            this.Txt_ProCA.Size = new System.Drawing.Size(191, 20);
            this.Txt_ProCA.TabIndex = 15;
            // 
            // Produits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.ProInformations);
            this.Controls.Add(this.ProProduit);
            this.Controls.Add(this.Btn_ProFermer);
            this.Name = "Produits";
            this.Text = "Produits";
            this.Load += new System.EventHandler(this.Produits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Produit)).EndInit();
            this.ProProduit.ResumeLayout(false);
            this.ProProduit.PerformLayout();
            this.ProInformations.ResumeLayout(false);
            this.ProInformations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DGV_Produit;
        private System.Windows.Forms.TextBox Txt_ProID;
        private System.Windows.Forms.TextBox Txt_ProLibelle;
        private System.Windows.Forms.TextBox Txt_ProPu;
        private System.Windows.Forms.TextBox Txt_ProRechercher;
        private System.Windows.Forms.ComboBox CB_ProCategories;
        private System.Windows.Forms.Button Btn_ProAjouter;
        private System.Windows.Forms.Button Btn_ProModifier;
        private System.Windows.Forms.Button Btn_ProSupprimer;
        private System.Windows.Forms.Button Btn_ProFermer;
        private System.Windows.Forms.GroupBox ProProduit;
        private System.Windows.Forms.GroupBox ProInformations;
        private System.Windows.Forms.TextBox Txt_ProCA;
        private System.Windows.Forms.TextBox Txt_ProNbrCommande;
    }
}