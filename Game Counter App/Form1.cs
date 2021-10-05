using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;
using System.Data.SqlClient;


namespace Game_Counter_App
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();

        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_user.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if(checkbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }

            else
            {
                txtPassword.PasswordChar = '*';
                txtComPassword.PasswordChar = '*';
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtComPassword.Text == "") 
            {
                MessageBox.Show("Username and Password fields are empty", "Sign Up failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtPassword.Text == txtComPassword.Text)
            {
                //con.Open();
                //string register = "INSERT INTO tbl_users VALUES ('" + txtUsername.Text + "', '" + txtPassword.Text + "')";
                //cmd = new OleDbCommand(register, con);
                //cmd.ExecuteNonQuery();           
                //con.Close();

                txtUsername.Text = "";
                txtPassword.Text = "";
                txtComPassword.Text = "";

                //MessageBox.Show("Your Account has been Successfully Created", "Registration Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Something is wrong!!! Your operating system is not yet activated", "Registration failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                MessageBox.Show("Password does not match, Please re-enter", "Registration Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtComPassword.Text = "";
                txtPassword.Focus();
            }

    

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
        }
    }
}
