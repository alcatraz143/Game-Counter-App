using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Game_Counter_App
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_user.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            //con.Open();
            //string login = "SELECT * FROM tbl_users WHERE username= '" + txtUsername.Text + "' and password= '" + txtPassword.Text + "'";
            //cmd = new OleDbCommand(login, con);
            //OleDbDataReader dr = cmd.ExecuteReader();



            if (txtUsername.Text == "admin" && txtPassword.Text == "12345")
            //if(dr.Read() == true)
            {
                
                new dashboard().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
                
            }

            else
            {
                txtPassword.PasswordChar = '*';
                
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
