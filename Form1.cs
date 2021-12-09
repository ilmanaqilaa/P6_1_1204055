﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace P6_1_1204055
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateDB(string cmd)
        {
                try
                {
                    //string connectionString = "Data Source=LAPTOP-4Q4UGOSK\P6_1204055;Initial Catalog=P6_1204055;Integrated Security=True";

                    SqlConnection myConnection = new SqlConnection(@"Data Source=LAPTOP-4Q4UGOSK\P6_1204055;Initial Catalog=P6_1204055;Integrated Security=True");

                    myConnection.Open();

                    SqlCommand myCommand = new SqlCommand();

                    myCommand.Connection = myConnection;

                    myCommand.CommandText = cmd;

                    myCommand.ExecuteNonQuery();

                    MessageBox.Show("Basisdata berhasil diperbarui", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string myCmd = "INSERT INTO msprodi VALUES('"
                + txtIdProdi.Text + "','"
                + txtNamaProdi.Text + "','"
                + txtSingkatan.Text + "','"
                + txtKaProdi.Text + "','"
                + txtSekProdi.Text + "')";

            UpdateDB(myCmd);
        }

        private void clear()
        {
            txtIdProdi.Text = "";
            txtNamaProdi.Text = "";
            txtSingkatan.Text = "";
            txtKaProdi.Text = "";
            txtSekProdi.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
