using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }
       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Por Favor Preencha Todos Os Campos." , "Erro" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtUsuario.Text == "Lucas" && txtSenha.Text == "FLAMENGO")
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha Incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
