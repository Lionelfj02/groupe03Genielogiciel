﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPersonne.Classes
{
    class CRUDAdresses
    {
        private Config db;
        private SqlConnection sqlcon;
        private SqlCommand sqlcmd;

        public bool AjouterAdresse(int idP, String Av, String Qua, String com, String ville, String pays)
        {
            bool saved = false;
            db = new Config();
            sqlcon = db.getSqlConnection();
            try
            {
                sqlcon.Open();
                if (sqlcon.State == ConnectionState.Open)
                {
                    String proc = "AddAddress";
                    sqlcmd = new SqlCommand(proc, sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add(new SqlParameter("@idP", SqlDbType.BigInt)).Value = idP;
                    sqlcmd.Parameters.Add(new SqlParameter("@av", SqlDbType.VarChar, 250)).Value = Av;
                    sqlcmd.Parameters.Add(new SqlParameter("@qua", SqlDbType.VarChar, 250)).Value = Qua;
                    sqlcmd.Parameters.Add(new SqlParameter("@com", SqlDbType.VarChar, 250)).Value = com;
                    sqlcmd.Parameters.Add(new SqlParameter("@ville", SqlDbType.VarChar, 250)).Value = ville;
                    sqlcmd.Parameters.Add(new SqlParameter("@pays", SqlDbType.VarChar, 250)).Value = pays;

                    if (sqlcmd.ExecuteNonQuery() > 0)
                    {
                        saved = true;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Sql Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return saved;
        }

        public bool ModifierAdresse(int id, int idP, String Av, String Qua, String com, String ville, String pays)
        {
            bool saved = false;
            db = new Config();
            sqlcon = db.getSqlConnection();
            try
            {
                sqlcon.Open();
                if (sqlcon.State == ConnectionState.Open)
                {
                    String proc = "UpdateAddress";
                    sqlcmd = new SqlCommand(proc, sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add(new SqlParameter("@idA", SqlDbType.BigInt)).Value = id;
                    sqlcmd.Parameters.Add(new SqlParameter("@idP", SqlDbType.BigInt)).Value = idP;
                    sqlcmd.Parameters.Add(new SqlParameter("@av", SqlDbType.VarChar, 250)).Value = Av;
                    sqlcmd.Parameters.Add(new SqlParameter("@qua", SqlDbType.VarChar, 250)).Value = Qua;
                    sqlcmd.Parameters.Add(new SqlParameter("@com", SqlDbType.VarChar, 250)).Value = com;
                    sqlcmd.Parameters.Add(new SqlParameter("@ville", SqlDbType.VarChar, 250)).Value = ville;
                    sqlcmd.Parameters.Add(new SqlParameter("@pays", SqlDbType.VarChar, 250)).Value = pays;

                    if (sqlcmd.ExecuteNonQuery() > 0)
                    {
                        saved = true;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Sql Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return saved;
        }

        public bool SupprimerAdresse(int id)
        {
            bool saved = false;
            db = new Config();
            sqlcon = db.getSqlConnection();
            try
            {
                sqlcon.Open();
                if (sqlcon.State == ConnectionState.Open)
                {
                    String proc = "DeleteAddress";
                    sqlcmd = new SqlCommand(proc, sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add(new SqlParameter("@idA", SqlDbType.BigInt)).Value = id;

                    if (sqlcmd.ExecuteNonQuery() > 0)
                    {
                        saved = true;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Sql Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return saved;
        }
    }
}
