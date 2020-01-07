namespace Application_Commandes
{
    partial class Clients
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
            this.Btn_CliAjouter = new System.Windows.Forms.Button();
            this.Btn_CliModifier = new System.Windows.Forms.Button();
            this.Btn_CliSupprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_CliID = new System.Windows.Forms.TextBox();
            this.Txt_CliNom = new System.Windows.Forms.TextBox();
            this.Txt_CliPrenom = new System.Windows.Forms.TextBox();
            this.Txt_CliRecherche = new System.Windows.Forms.TextBox();
            this.DGV_Cli_1 = new System.Windows.Forms.DataGridView();
            this.Txt_CliCA = new System.Windows.Forms.TextBox();
            this.Txt_CliNbrTotale = new System.Windows.Forms.TextBox();
            this.DGV_Cli_2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.CRUD_Client = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_CliFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Cli_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Cli_2)).BeginInit();
            this.CRUD_Client.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_CliAjouter
            // 
            this.Btn_CliAjouter.Location = new System.Drawing.Point(289, 28);
            this.Btn_CliAjouter.Name = "Btn_CliAjouter";
            this.Btn_CliAjouter.Size = new System.Drawing.Size(75, 23);
            this.Btn_CliAjouter.TabIndex = 0;
            this.Btn_CliAjouter.Text = "Ajouter";
            this.Btn_CliAjouter.UseVisualStyleBackColor = true;
            this.Btn_CliAjouter.Click += new System.EventHandler(this.Btn_CliAjouter_Click);
            // 
            // Btn_CliModifier
            // 
            this.Btn_CliModifier.Location = new System.Drawing.Point(289, 57);
            this.Btn_CliModifier.Name = "Btn_CliModifier";
            this.Btn_CliModifier.Size = new System.Drawing.Size(75, 23);
            this.Btn_CliModifier.TabIndex = 1;
            this.Btn_CliModifier.Text = "Modifier";
            this.Btn_CliModifier.UseVisualStyleBackColor = true;
            this.Btn_CliModifier.Click += new System.EventHandler(this.Btn_CliModifier_Click);
            // 
            // Btn_CliSupprimer
            // 
            this.Btn_CliSupprimer.Location = new System.Drawing.Point(289, 86);
            this.Btn_CliSupprimer.Name = "Btn_CliSupprimer";
            this.Btn_CliSupprimer.Size = new System.Drawing.Size(75, 23);
            this.Btn_CliSupprimer.TabIndex = 2;
            this.Btn_CliSupprimer.Text = "Supprimer";
            this.Btn_CliSupprimer.UseVisualStyleBackColor = true;
            this.Btn_CliSupprimer.Click += new System.EventHandler(this.Btn_CliSupprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prenom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Recherche :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Chiffre Affaire :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nbr Totale Client :";
            // 
            // Txt_CliID
            // 
            this.Txt_CliID.Enabled = false;
            this.Txt_CliID.Location = new System.Drawing.Point(69, 34);
            this.Txt_CliID.Name = "Txt_CliID";
            this.Txt_CliID.Size = new System.Drawing.Size(168, 20);
            this.Txt_CliID.TabIndex = 9;
            // 
            // Txt_CliNom
            // 
            this.Txt_CliNom.Location = new System.Drawing.Point(69, 60);
            this.Txt_CliNom.Name = "Txt_CliNom";
            this.Txt_CliNom.Size = new System.Drawing.Size(168, 20);
            this.Txt_CliNom.TabIndex = 10;
            // 
            // Txt_CliPrenom
            // 
            this.Txt_CliPrenom.Location = new System.Drawing.Point(69, 86);
            this.Txt_CliPrenom.Name = "Txt_CliPrenom";
            this.Txt_CliPrenom.Size = new System.Drawing.Size(168, 20);
            this.Txt_CliPrenom.TabIndex = 11;
            // 
            // Txt_CliRecherche
            // 
            this.Txt_CliRecherche.Location = new System.Drawing.Point(116, 10);
            this.Txt_CliRecherche.Name = "Txt_CliRecherche";
            this.Txt_CliRecherche.Size = new System.Drawing.Size(146, 20);
            this.Txt_CliRecherche.TabIndex = 12;
            this.Txt_CliRecherche.TextChanged += new System.EventHandler(this.Txt_CliRecherche_TextChanged);
            // 
            // DGV_Cli_1
            // 
            this.DGV_Cli_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Cli_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Cli_1.Location = new System.Drawing.Point(30, 259);
            this.DGV_Cli_1.Name = "DGV_Cli_1";
            this.DGV_Cli_1.Size = new System.Drawing.Size(379, 146);
            this.DGV_Cli_1.TabIndex = 13;
            this.DGV_Cli_1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Cli_1_CellClick);
            // 
            // Txt_CliCA
            // 
            this.Txt_CliCA.Enabled = false;
            this.Txt_CliCA.Location = new System.Drawing.Point(116, 36);
            this.Txt_CliCA.Name = "Txt_CliCA";
            this.Txt_CliCA.Size = new System.Drawing.Size(146, 20);
            this.Txt_CliCA.TabIndex = 14;
            // 
            // Txt_CliNbrTotale
            // 
            this.Txt_CliNbrTotale.Enabled = false;
            this.Txt_CliNbrTotale.Location = new System.Drawing.Point(116, 62);
            this.Txt_CliNbrTotale.Name = "Txt_CliNbrTotale";
            this.Txt_CliNbrTotale.Size = new System.Drawing.Size(146, 20);
            this.Txt_CliNbrTotale.TabIndex = 15;
            // 
            // DGV_Cli_2
            // 
            this.DGV_Cli_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Cli_2.Location = new System.Drawing.Point(30, 427);
            this.DGV_Cli_2.Name = "DGV_Cli_2";
            this.DGV_Cli_2.Size = new System.Drawing.Size(379, 94);
            this.DGV_Cli_2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Commentaires :";
            // 
            // CRUD_Client
            // 
            this.CRUD_Client.Controls.Add(this.Txt_CliPrenom);
            this.CRUD_Client.Controls.Add(this.Btn_CliAjouter);
            this.CRUD_Client.Controls.Add(this.Btn_CliModifier);
            this.CRUD_Client.Controls.Add(this.Btn_CliSupprimer);
            this.CRUD_Client.Controls.Add(this.label1);
            this.CRUD_Client.Controls.Add(this.label2);
            this.CRUD_Client.Controls.Add(this.label3);
            this.CRUD_Client.Controls.Add(this.Txt_CliID);
            this.CRUD_Client.Controls.Add(this.Txt_CliNom);
            this.CRUD_Client.Location = new System.Drawing.Point(30, 12);
            this.CRUD_Client.Name = "CRUD_Client";
            this.CRUD_Client.Size = new System.Drawing.Size(379, 135);
            this.CRUD_Client.TabIndex = 0;
            this.CRUD_Client.TabStop = false;
            this.CRUD_Client.Text = "Client";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Txt_CliRecherche);
            this.groupBox1.Controls.Add(this.Txt_CliNbrTotale);
            this.groupBox1.Controls.Add(this.Txt_CliCA);
            this.groupBox1.Location = new System.Drawing.Point(30, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // Btn_CliFermer
            // 
            this.Btn_CliFermer.Location = new System.Drawing.Point(336, 178);
            this.Btn_CliFermer.Name = "Btn_CliFermer";
            this.Btn_CliFermer.Size = new System.Drawing.Size(75, 49);
            this.Btn_CliFermer.TabIndex = 12;
            this.Btn_CliFermer.Text = "Fermer";
            this.Btn_CliFermer.UseVisualStyleBackColor = true;
            this.Btn_CliFermer.Click += new System.EventHandler(this.Btn_CliFermer_Click);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 533);
            this.Controls.Add(this.Btn_CliFermer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CRUD_Client);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DGV_Cli_2);
            this.Controls.Add(this.DGV_Cli_1);
            this.Name = "Clients";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Cli_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Cli_2)).EndInit();
            this.CRUD_Client.ResumeLayout(false);
            this.CRUD_Client.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_CliAjouter;
        private System.Windows.Forms.Button Btn_CliModifier;
        private System.Windows.Forms.Button Btn_CliSupprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_CliID;
        private System.Windows.Forms.TextBox Txt_CliNom;
        private System.Windows.Forms.TextBox Txt_CliPrenom;
        private System.Windows.Forms.TextBox Txt_CliRecherche;
        private System.Windows.Forms.DataGridView DGV_Cli_1;
        private System.Windows.Forms.TextBox Txt_CliCA;
        private System.Windows.Forms.TextBox Txt_CliNbrTotale;
        private System.Windows.Forms.DataGridView DGV_Cli_2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox CRUD_Client;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_CliFermer;
    }
}