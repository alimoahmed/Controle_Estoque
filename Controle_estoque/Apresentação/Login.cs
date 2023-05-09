using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Controle_estoque.Modelo;

namespace Controle_estoque
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form_login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnolho_MouseDown(object sender, MouseEventArgs e)
        {
            txtsenha.UseSystemPasswordChar = false;
        }

        private void btnolho_MouseUp(object sender, MouseEventArgs e)
        {
            txtsenha.UseSystemPasswordChar = true;
        }

        private void btncadastro_Click(object sender, EventArgs e)
        {
            string User = "adm";
            string Password = "adm";
            if (txtuser.Text == User & txtsenha.Text == Password)
            {
                MessageBox.Show("Acesso liberado!");
                CadUser FrmMain = new CadUser();
                FrmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreta");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtuser.Text, txtsenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Acesso liberado!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listagem FrmMain = new Listagem();
                    FrmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("login ou senha incorreta", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show(controle.mensagem);
            }

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
