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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }
        Client Cli = new Client();
        ApplicationCommandesEntities BD = new ApplicationCommandesEntities();
        private void Clients_Load(object sender, EventArgs e)
        {
            Clear();
            Count_ID();
            DGV_1_Load();
        }
        public void Clear()
        {
            Txt_CliID.Text ="";
            Txt_CliCA.Text = "";
            Txt_CliNbrTotale.Text = "";
            Txt_CliNom.Text = "";
            Txt_CliPrenom.Text = "";
            Txt_CliRecherche.Text = "";
        }
        public void DGV_1_Load()
        {
            DGV_Cli_1.DataSource = BD.Clients.Select(p => new { ID = p.ID, Nom = p.Nom, Prenom = p.Prenom }).ToList();
        }
        public void Count_ID()
        {
            Txt_CliID.Text = BD.Clients.Max(p => p.ID).ToString();
            Txt_CliNbrTotale.Text = BD.Clients.Count().ToString();
        }
        private void Btn_CliFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_CliAjouter_Click(object sender, EventArgs e)
        {
            Cli.ID = int.Parse(Txt_CliID.Text);
            Cli.Nom = Txt_CliNom.Text;
            Cli.Prenom = Txt_CliPrenom.Text;
            BD.Clients.Add(Cli);
            BD.SaveChanges();
            Clear();
            DGV_1_Load();
            Count_ID();
        }

        private void Btn_CliSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Voulez-vous supprimer ce Client ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
            {
                Cli.ID = (int)DGV_Cli_1.CurrentRow.Cells[0].Value;
                Client rm = BD.Clients.Where(c => c.ID == Cli.ID).First();//First qu'il trouve pour valider cast aussi
                BD.Clients.Remove(rm);
                BD.SaveChanges();
                Clear();
                Count_ID();
                DGV_1_Load();
            }
        }

        private void Btn_CliModifier_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Voulez-vous modifier ce Client ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
            {
                Cli.ID = (int)DGV_Cli_1.CurrentRow.Cells[0].Value;// Enregistrer la valeur a comparer du DGV
                Client A = new Client();
                A.ID = int.Parse(Txt_CliID.Text);
                A.Nom = Txt_CliNom.Text;
                A.Prenom = Txt_CliPrenom.Text;
                Client rm = BD.Clients.Where(c => c.ID == Cli.ID).First();//First qu'il trouve pour valider cast aussi                                                           //rm.ID = A.ID; // ID is primary LOL
                rm.Nom = A.Nom;
                rm.Prenom = A.Prenom;
                BD.SaveChanges();
                Clear();
                Count_ID();
                DGV_1_Load();
            }
        }

        private void Txt_CliRecherche_TextChanged(object sender, EventArgs e)
        {
            string A = Txt_CliRecherche.Text;
            if (BD.Clients.ToList().Exists(c => c.Nom == A) == true)
            {
                Client rm = BD.Clients.Where(c => c.Nom == A).First();
                DialogResult D = MessageBox.Show("Client ID est :" + rm.ID, "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void DGV_Cli_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_CliID.Text = DGV_Cli_1.CurrentRow.Cells[0].Value.ToString();
            Txt_CliNom.Text = DGV_Cli_1.CurrentRow.Cells[1].Value.ToString();
            Txt_CliPrenom.Text = DGV_Cli_1.CurrentRow.Cells[2].Value.ToString(); 
        }
    }
}
