using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPersonne.UserControls
{
    public partial class Adresses : UserControl
    {
        public int idA;
        public int idP;
        private Classes.Config db;
        private SqlConnection con;
        private SqlCommand cmd;
        private DialogResult Dr;
        private static Adresses adresse;
        public static Adresses interfaces
        {
            get
            {
                if(adresse == null)
                {
                    adresse = new Adresses();
                }
                return adresse;
            }
        }
        public Adresses()
        {
            InitializeComponent();
            RemplirePersonne();
            PopulateCountryData();
        }

        private void PopulateCountryData()
        {
            comboCountry.Items.Add("Algérie");
            comboCountry.Items.Add("Angola");
            comboCountry.Items.Add("Bénin");
            comboCountry.Items.Add("Botswana");
            comboCountry.Items.Add("Burkina Faso");
            comboCountry.Items.Add("Burundi");
            comboCountry.Items.Add("Cabo Verde");
            comboCountry.Items.Add("Cameroun");
            comboCountry.Items.Add("République Centrafricaine");
            comboCountry.Items.Add("Tchad");
            comboCountry.Items.Add("Comores");
            comboCountry.Items.Add("République Démocratique du Congo");
            comboCountry.Items.Add("République du Congo");
            comboCountry.Items.Add("Côte d'Ivoire");
            comboCountry.Items.Add("Djibouti");
            comboCountry.Items.Add("Égypte");
            comboCountry.Items.Add("Guinée Équatoriale");
            comboCountry.Items.Add("Érythrée");
            comboCountry.Items.Add("Eswatini");
            comboCountry.Items.Add("Éthiopie");
            comboCountry.Items.Add("Gabon");
            comboCountry.Items.Add("Gambie");
            comboCountry.Items.Add("Ghana");
            comboCountry.Items.Add("Guinée");
            comboCountry.Items.Add("Guinée-Bissau");
            comboCountry.Items.Add("Kenya");
            comboCountry.Items.Add("Lesotho");
            comboCountry.Items.Add("Libéria");
            comboCountry.Items.Add("Libye");
            comboCountry.Items.Add("Madagascar");
            comboCountry.Items.Add("Malawi");
            comboCountry.Items.Add("Mali");
            comboCountry.Items.Add("Mauritanie");
            comboCountry.Items.Add("Maurice");
            comboCountry.Items.Add("Maroc");
            comboCountry.Items.Add("Mozambique");
            comboCountry.Items.Add("Namibie");
            comboCountry.Items.Add("Niger");
            comboCountry.Items.Add("Nigéria");
            comboCountry.Items.Add("Rwanda");
            comboCountry.Items.Add("Sao Tomé-et-Principe");
            comboCountry.Items.Add("Sénégal");
            comboCountry.Items.Add("Seychelles");
            comboCountry.Items.Add("Sierra Leone");
            comboCountry.Items.Add("Somalie");
            comboCountry.Items.Add("Afrique du Sud");
            comboCountry.Items.Add("Soudan du Sud");
            comboCountry.Items.Add("Soudan");
            comboCountry.Items.Add("Tanzanie");
            comboCountry.Items.Add("Togo");
            comboCountry.Items.Add("Tunisie");
            comboCountry.Items.Add("Ouganda");
            comboCountry.Items.Add("Zambie");
            comboCountry.Items.Add("Zimbabwe");
        }
        public void RemplirePersonne()
        {
            db = new Classes.Config();
            con = db.getSqlConnection();
            String sql = "select idP as id,CONCAT(nom,' ',postnom,' ',prenom) as fullname from personne";
            try
            {
                if (db.ServerType == "Sql Server")
                {
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        cmd = new SqlCommand(sql, con);
                        SqlDataAdapter data = new SqlDataAdapter(cmd);
                        DataTable tablePerson = new DataTable();
                        data.Fill(tablePerson);
                        ListePersonnes.DataSource = tablePerson;
                        ListePersonnes.DisplayMember = "fullname";
                        ListePersonnes.ValueMember = "id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AfficherAdresses(String text)
        {
            db = new Classes.Config();
            con = db.getSqlConnection();
            String proc = "SearchAddress";
            if (db.ServerType == "Sql Server")
            {
                try
                {
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        RemplirePersonne();
                        tableAddress.Rows.Clear();
                        cmd = new SqlCommand(proc, con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@fullname", SqlDbType.VarChar, 250)).Value = text;
                        cmd.Parameters.Add(new SqlParameter("@av", SqlDbType.VarChar, 250)).Value = text;
                        cmd.Parameters.Add(new SqlParameter("@qua", SqlDbType.VarChar, 250)).Value = text;
                        cmd.Parameters.Add(new SqlParameter("@com", SqlDbType.VarChar, 250)).Value = text;
                        cmd.Parameters.Add(new SqlParameter("@ville", SqlDbType.VarChar, 250)).Value = text;
                        cmd.Parameters.Add(new SqlParameter("@pays", SqlDbType.VarChar, 250)).Value = text;
                        SqlDataReader dataReader = cmd.ExecuteReader();
                        int num = 1;
                        while (dataReader.Read())
                        {
                            try
                            {
                                tableAddress.Rows.Add(num, dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(6), dataReader.GetString(5), dataReader.GetString(7));
                                num++;
                            }
                            catch (Exception sqlEx)
                            {
                                MessageBox.Show(sqlEx.Message, "Sql Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        dataReader.Close();
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message, "Sql Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        public String isEmpty()
        {
            if(ListePersonnes.Text == "")
            {
                return "Choisissez Une Personne";
            }
            if (txtAv.Text == "")
            {
                return "Completez l'Avenue";
            }
            if (txtQ.Text == "")
            {
                return "Completez le Quartier";
            }
            if (txtCom.Text == "")
            {
                return "Completez la Commune";
            }
            if (txtVi.Text == "")
            {
                return "Completez la Ville";
            }
            if (comboCountry.Text == "")
            {
                return "Completez le Pays";
            }
            return null;
        }
        public void ViderChamps()
        {
            ListePersonnes.Text = "";
            txtAv.Text = "";
            txtQ.Text = "";
            txtCom.Text = "";
            txtVi.Text = "";
            comboCountry.Text = "";
        }
        private void Adresses_Load(object sender, EventArgs e)
        {
            AfficherAdresses("");
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if(isEmpty() == null)
            {
                Classes.CRUDAdresses add = new Classes.CRUDAdresses();
                idP = Convert.ToInt32(ListePersonnes.SelectedValue);
                if (add.AjouterAdresse(idP, txtAv.Text, txtQ.Text, txtCom.Text, txtVi.Text, comboCountry.Text) == true)
                {
                    AfficherAdresses("");
                    MessageBox.Show("Adresse Ajouter Avec Succee", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ViderChamps();
                }
                else
                {
                    MessageBox.Show("Erreur d'Ajout d'Adresse", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(isEmpty(), "Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btMod_Click(object sender, EventArgs e)
        {
            if(tableAddress.Rows.Count > 0)
            {
                if(isEmpty() == null)
                {
                    idA = Convert.ToInt32(tableAddress.CurrentRow.Cells[1].Value);
                    idP = Convert.ToInt32(ListePersonnes.SelectedValue);
                    Classes.CRUDAdresses update = new Classes.CRUDAdresses();
                    Dr = MessageBox.Show("Voulez-vous Modifier Cette Adresse??", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Dr == DialogResult.Yes)
                    {
                        if (update.ModifierAdresse(idA, idP, txtAv.Text, txtQ.Text, txtCom.Text, txtVi.Text, comboCountry.Text) == true)
                        {
                            AfficherAdresses("");
                            MessageBox.Show("Adresse Modifier Avec Succee", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ViderChamps();
                        }
                        else
                        {
                            MessageBox.Show("Erreur de Modification de l'Adresse", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Modification Annulee", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(isEmpty(), "Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Veuillez Remplire la Table", "Table", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btSup_Click(object sender, EventArgs e)
        {
            if(tableAddress.Rows.Count > 0)
            {
                if(isEmpty() == null)
                {
                    Classes.CRUDAdresses delete = new Classes.CRUDAdresses();
                    idA = Convert.ToInt32(tableAddress.CurrentRow.Cells[1].Value);
                    Dr = MessageBox.Show("Voulez-vous Supprimer Cette Adresse??", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Dr == DialogResult.Yes)
                    {
                        delete.SupprimerAdresse(idA);
                        AfficherAdresses("");
                        MessageBox.Show("Adresse Supprimer Avec Succee", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ViderChamps();
                    }
                    else
                    {
                        MessageBox.Show("Suppresion Annulee", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(isEmpty(), "Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Veuillez Remplire la Table", "Table", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tableAddress_Click(object sender, EventArgs e)
        {

            if(tableAddress.Rows.Count > 0)
            {
                idA = Convert.ToInt32(tableAddress.CurrentRow.Cells[1].Value);
                idP = Convert.ToInt32(ListePersonnes.SelectedValue);
                ListePersonnes.Text = tableAddress.CurrentRow.Cells[3].Value.ToString();
                txtAv.Text = tableAddress.CurrentRow.Cells[4].Value.ToString();
                txtQ.Text = tableAddress.CurrentRow.Cells[5].Value.ToString();
                txtCom.Text = tableAddress.CurrentRow.Cells[6].Value.ToString();
                txtVi.Text = tableAddress.CurrentRow.Cells[7].Value.ToString();
                comboCountry.Text = tableAddress.CurrentRow.Cells[8].Value.ToString();
            }
            else
            {
                MessageBox.Show("Veuillez Remplire la Table", "Table", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            Modals.PreviewRapport printer = new Modals.PreviewRapport();
            db = new Classes.Config();
            con = db.getSqlConnection();
            if (tableAddress.Rows.Count > 0)
            {
                try
                {
                    if (db.ServerType == "Sql Server")
                    {
                        con.Open();
                        try
                        {
                            if (con.State == ConnectionState.Open)
                            {
                                String sql = "select * from listPersonWithNumberAndAddress";

                                cmd = new SqlCommand(sql, con);
                                SqlDataAdapter data = new SqlDataAdapter(cmd);
                                DataTable tablePersonWithAddr = new DataTable();
                                data.Fill(tablePersonWithAddr);
                                var listPersonneWithAddr = tablePersonWithAddr;

                                printer.preview.LocalReport.ReportEmbeddedResource = "GestionPersonne.Rapports.ListePersonnes.rdlc";
                                printer.preview.LocalReport.DataSources.Add(new ReportDataSource("listePersonnesNumAdresse", listPersonneWithAddr));
                                printer.preview.RefreshReport();
                                printer.ShowDialog();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Table is Empty, fill it before", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                AfficherAdresses("");
            }
            else
            {
                AfficherAdresses(txtSearch.Text);
            }
        }
    }
}
