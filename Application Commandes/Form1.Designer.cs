namespace Application_Commandes
{
    partial class Categories
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
            this.Btn_CatAjouter = new System.Windows.Forms.Button();
            this.Btn_CatModifier = new System.Windows.Forms.Button();
            this.Btn_CatSupprimer = new System.Windows.Forms.Button();
            this.Btn_CatRechercher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_CatID = new System.Windows.Forms.TextBox();
            this.Txt_CatLibelle = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_CatFermer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_CatNbrProuit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_CatAjouter
            // 
            this.Btn_CatAjouter.Location = new System.Drawing.Point(390, 27);
            this.Btn_CatAjouter.Name = "Btn_CatAjouter";
            this.Btn_CatAjouter.Size = new System.Drawing.Size(75, 23);
            this.Btn_CatAjouter.TabIndex = 0;
            this.Btn_CatAjouter.Text = "Ajouter";
            this.Btn_CatAjouter.UseVisualStyleBackColor = true;
            // 
            // Btn_CatModifier
            // 
            this.Btn_CatModifier.Location = new System.Drawing.Point(390, 56);
            this.Btn_CatModifier.Name = "Btn_CatModifier";
            this.Btn_CatModifier.Size = new System.Drawing.Size(75, 23);
            this.Btn_CatModifier.TabIndex = 1;
            this.Btn_CatModifier.Text = "Modifier";
            this.Btn_CatModifier.UseVisualStyleBackColor = true;
            // 
            // Btn_CatSupprimer
            // 
            this.Btn_CatSupprimer.Location = new System.Drawing.Point(390, 85);
            this.Btn_CatSupprimer.Name = "Btn_CatSupprimer";
            this.Btn_CatSupprimer.Size = new System.Drawing.Size(75, 23);
            this.Btn_CatSupprimer.TabIndex = 2;
            this.Btn_CatSupprimer.Text = "Supprimer";
            this.Btn_CatSupprimer.UseVisualStyleBackColor = true;
            // 
            // Btn_CatRechercher
            // 
            this.Btn_CatRechercher.Location = new System.Drawing.Point(390, 114);
            this.Btn_CatRechercher.Name = "Btn_CatRechercher";
            this.Btn_CatRechercher.Size = new System.Drawing.Size(75, 23);
            this.Btn_CatRechercher.TabIndex = 3;
            this.Btn_CatRechercher.Text = "Rechercher";
            this.Btn_CatRechercher.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Libelle :";
            // 
            // Txt_CatID
            // 
            this.Txt_CatID.Location = new System.Drawing.Point(105, 30);
            this.Txt_CatID.Name = "Txt_CatID";
            this.Txt_CatID.Size = new System.Drawing.Size(202, 20);
            this.Txt_CatID.TabIndex = 8;
            // 
            // Txt_CatLibelle
            // 
            this.Txt_CatLibelle.Location = new System.Drawing.Point(105, 73);
            this.Txt_CatLibelle.Name = "Txt_CatLibelle";
            this.Txt_CatLibelle.Size = new System.Drawing.Size(202, 20);
            this.Txt_CatLibelle.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(313, 209);
            this.dataGridView1.TabIndex = 12;
            // 
            // Btn_CatFermer
            // 
            this.Btn_CatFermer.Location = new System.Drawing.Point(390, 270);
            this.Btn_CatFermer.Name = "Btn_CatFermer";
            this.Btn_CatFermer.Size = new System.Drawing.Size(75, 53);
            this.Btn_CatFermer.TabIndex = 13;
            this.Btn_CatFermer.Text = "Fermer";
            this.Btn_CatFermer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nbr Produits :";
            // 
            // Txt_CatNbrProuit
            // 
            this.Txt_CatNbrProuit.Enabled = false;
            this.Txt_CatNbrProuit.Location = new System.Drawing.Point(436, 180);
            this.Txt_CatNbrProuit.Name = "Txt_CatNbrProuit";
            this.Txt_CatNbrProuit.Size = new System.Drawing.Size(29, 20);
            this.Txt_CatNbrProuit.TabIndex = 15;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 341);
            this.Controls.Add(this.Txt_CatNbrProuit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_CatFermer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Txt_CatLibelle);
            this.Controls.Add(this.Txt_CatID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_CatRechercher);
            this.Controls.Add(this.Btn_CatSupprimer);
            this.Controls.Add(this.Btn_CatModifier);
            this.Controls.Add(this.Btn_CatAjouter);
            this.Name = "Categories";
            this.Text = "Categories";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_CatAjouter;
        private System.Windows.Forms.Button Btn_CatModifier;
        private System.Windows.Forms.Button Btn_CatSupprimer;
        private System.Windows.Forms.Button Btn_CatRechercher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_CatID;
        private System.Windows.Forms.TextBox Txt_CatLibelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_CatFermer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_CatNbrProuit;
    }
}

