using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Commandes
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }
        Category Cat = new Category(); // Cree un objet de la table Categories
        ApplicationCommandesEntities DB = new ApplicationCommandesEntities(); // Entity de la Base de donnees !
        public void Clear()
        {
            Txt_CatID.Text = "";
            Txt_CatLibelle.Text = "";
            Txt_CatNbrProuit.Text = "";
        }
        private void Categories_Load(object sender, EventArgs e)
        {
            Clear();
            Count_ID();
            DGV_Load();
        }
        public void Count_ID()
        {
            Txt_CatID.Text = DB.Categories.Max(p => p.ID).ToString();
            Txt_CatNbrProuit.Text = DB.Categories.Count().ToString();
        }
        private void Btn_CatAjouter_Click(object sender, EventArgs e)
        {
            Cat.ID = int.Parse(Txt_CatID.Text);
            Cat.Libelle = Txt_CatLibelle.Text;
            DB.Categories.Add(Cat);
            DB.SaveChanges();
            Clear();
            Count_ID();
            DGV_Load();
            MessageBox.Show("Donnee Inserer !", "Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void DGV_Load()
        {
                DGV_Cat.DataSource = DB.Categories.Select(p => new { ID = p.ID, Libelle = p.Libelle }).ToList();
        }

        private void Btn_CatFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_CatModifier_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Voulez-vous modifier cette categorie ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
            {
                Cat.ID = (int)DGV_Cat.CurrentRow.Cells[0].Value;
                Category A = new Category();
                A.ID = int.Parse(Txt_CatID.Text);
                A.Libelle = Txt_CatLibelle.Text;
                    Category rm = DB.Categories.Where(c => c.ID == Cat.ID).First();//First qu'il trouve pour valider cast aussi
                    //rm.ID = A.ID; // ID is primary LOL
                    rm.Libelle = A.Libelle;
                    DB.SaveChanges();
                    Clear();
                    Count_ID();
                    DGV_Load(); 
            }
        }
        private void Btn_CatSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Voulez-vous supprimer cette categorie ?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(D == DialogResult.Yes)
            {
                Cat.ID= (int)DGV_Cat.CurrentRow.Cells[0].Value;
                Category rm = DB.Categories.Where(c => c.ID == Cat.ID).First();//First qu'il trouve pour valider cast aussi
                DB.Categories.Remove(rm);
                DB.SaveChanges();
                Clear();
                Count_ID();
                DGV_Load();
            }
        }

        private void DGV_Cat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_CatID.Text = DGV_Cat.CurrentRow.Cells[0].Value.ToString(); ;
            Txt_CatLibelle.Text = DGV_Cat.CurrentRow.Cells[1].Value.ToString(); ;
        }

        private void Btn_CatRechercher_Click(object sender, EventArgs e)
        {
            string A = Txt_CatLibelle.Text;
            if(DB.Categories.ToList().Exists(c => c.Libelle == A) == true) {
                Category rm = DB.Categories.Where(c => c.Libelle == A).First();
                DialogResult D = MessageBox.Show("Categorie ID est :"+rm.ID, "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult D = MessageBox.Show("Categorie Non trouver", "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
