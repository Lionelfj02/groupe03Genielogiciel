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
    public partial class Personnes : UserControl
    {
        private Classes.Config db;
        private static Personnes personnes;
        private SqlConnection con;
        private SqlCommand cmd;
        private int idP;
        DialogResult Dr;
        public static Personnes interfaces
        {
            get
            {
                if(personnes == null)
                {
                    personnes = new Personnes();
                }
                return personnes;
            }
        }
        public Personnes()
        {
            InitializeComponent();
        }

        public String isEmpty()
        {
            if(txtname.Text == "")
            {
                return "Completez le Nom";
            }
            if (txtpost.Text == "")
            {
                return "Completez le Post-Nom";
            }
            if (txtpre.Text == "")
            {
                return "Completez le Prenom";
            }
            if (txtSex.Text == "")
            {
                return "Completez le Sexe";
            }
            return null;

        }
        private void Personnes_Load(object sender, EventArgs e)
        {
            AfficherPersonnes("");
        }

        public void AfficherPersonnes(String text)
        {
            db = new Classes.Config();
            con = db.getSqlConnection();
            String proc = "SearchPerson";
            try
            {
                if(db.ServerType == "Sql Server")
                {
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        tablePerson.Rows.Clear();
                        cmd = new SqlCommand(proc, con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar, 250)).Value = text;
                        cmd.Parameters.Add(new SqlParameter("@pnom", SqlDbType.VarChar, 250)).Value = text;
                        cmd.Parameters.Add(new SqlParameter("@prnom", SqlDbType.VarChar, 250)).Value = text;
                        cmd.Parameters.Add(new SqlParameter("@sex", SqlDbType.VarChar, 250)).Value = text;
                        SqlDataReader dataReader = cmd.ExecuteReader();
                        int num = 1;
                        while (dataReader.Read())
                        {
                            try
                            {
                                tablePerson.Rows.Add(num, dataReader.GetValue(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
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
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        public void ViderleChamp()
        {
            txtname.Text = "";
            txtpost.Text = "";
            txtpre.Text = "";
            txtSex.Text = "";
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            if(isEmpty() == null)
            {
                db = new Classes.Config();
                con = db.getSqlConnection();
                try
                {
                    con.Open();
                    if(con.State == ConnectionState.Open)
                    {
                        Classes.CRUDPersonnes sqladd = new Classes.CRUDPersonnes();
                        if (sqladd.AjouterPersonne(txtname.Text, txtpost.Text, txtpre.Text, Convert.ToChar(txtSex.Text)) == true)
                        {
                            AfficherPersonnes("");
                            MessageBox.Show("Personne Ajouter Avec Succee", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ViderleChamp();
                        }
                        else
                        {
                            MessageBox.Show("Erreur d'Ajout de la Personne", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(isEmpty(), "Saisie", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btMod_Click(object sender, EventArgs e)
        {
            if (tablePerson.Rows.Count > 0)
            {
                idP = Convert.ToInt32(tablePerson.CurrentRow.Cells[1].Value);
                if (isEmpty() == null)
                {
                    db = new Classes.Config();
                    con = db.getSqlConnection();
                    try
                    {
                        con.Open();
                        if (con.State == ConnectionState.Open)
                        {
                            Classes.CRUDPersonnes sqlupdate = new Classes.CRUDPersonnes();
                            Dr = MessageBox.Show("Voulez-vous Modifier cette Personne??", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (Dr == DialogResult.Yes)
                            {
                                if (sqlupdate.ModifierPersonne(idP, txtname.Text, txtpost.Text, txtpre.Text, Convert.ToChar(txtSex.Text)) == true)
                                {
                                    AfficherPersonnes("");
                                    MessageBox.Show("Personne Modifier Avec Succee", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ViderleChamp();
                                }
                                else
                                {
                                    MessageBox.Show("Erreur de Modification de la Personne", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    
                                }
                            }
                            else
                            {
                                MessageBox.Show("Modification Annule", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show(isEmpty(), "Saisie", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Veuillez Remplire la Table", "Modifier", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btSup_Click(object sender, EventArgs e)
        {
            if (tablePerson.Rows.Count > 0)
            {
                idP = Convert.ToInt32(tablePerson.CurrentRow.Cells[1].Value);
                Classes.CRUDPersonnes sqlSupprimer = new Classes.CRUDPersonnes();
                int numtel = sqlSupprimer.selectPhoneByIdsql(idP);
                int numaddres = sqlSupprimer.selectAddressByIdsql(idP);
                if (numtel > 0 && numaddres == 0)
                {
                    Dr = MessageBox.Show("Cette Personne a " + numtel + " Numero de telephone.\nVoulez-vous Vraiment Supprimer Cette Personne??", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Dr == DialogResult.Yes)
                    {
                        sqlSupprimer.SupprimerPersonne(idP);
                        AfficherPersonnes("");
                        MessageBox.Show("Personne et numero Supprimer Avec Succee", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ViderleChamp();
                    }
                    else
                    {
                        MessageBox.Show("Suppression Annule", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (numtel == 0 && numaddres > 0)
                {
                    Dr = MessageBox.Show("Cette Personne a " + numaddres + " Adresse.\nVoulez-vous Vraiment Supprimer Cette Personne??", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Dr == DialogResult.Yes)
                    {
                        sqlSupprimer.SupprimerPersonne(idP);
                        AfficherPersonnes("");
                        MessageBox.Show("Personne et Adresse Supprimer avec Succee", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ViderleChamp();
                    }
                    else
                    {
                        MessageBox.Show("Suppression Annule", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (numtel > 0 && numaddres > 0)
                {
                    Dr = MessageBox.Show("Cette Personne a " + numaddres + " Adresse(s) et " + numtel + " Numero(s) de telephone(s).\nVoulez-vous Vraiment Supprimer Cette Personne??", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Dr == DialogResult.Yes)
                    {
                        sqlSupprimer.SupprimerPersonne(idP);
                        AfficherPersonnes("");
                        MessageBox.Show("Personne,numero et Adresse Supprimer Avec Succee", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ViderleChamp();
                    }
                    else
                    {
                        MessageBox.Show("Suppression Annule", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    Dr = MessageBox.Show("Voulez-vous Vraiment Supprimer Cette Personne??", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Dr == DialogResult.Yes)
                    {
                        sqlSupprimer.SupprimerPersonne(idP);
                        AfficherPersonnes("");
                        MessageBox.Show("Personne Supprimer Avec Succee", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ViderleChamp();
                    }
                    else
                    {
                        MessageBox.Show("Suppression Annule", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

            }
            else
            {
                MessageBox.Show("Veuillez Remplire la Table", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tablePerson_Click(object sender, EventArgs e)
        {
            if(tablePerson.Rows.Count > 0)
            {
                idP = Convert.ToInt32(tablePerson.CurrentRow.Cells[1].Value);
                txtname.Text = tablePerson.CurrentRow.Cells[4].Value.ToString();
                txtpost.Text = tablePerson.CurrentRow.Cells[3].Value.ToString();
                txtpre.Text = tablePerson.CurrentRow.Cells[2].Value.ToString();
                txtSex.Text = tablePerson.CurrentRow.Cells[5].Value.ToString();
            }
            else
            {
                MessageBox.Show("Veuillez Remplire la Table", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
