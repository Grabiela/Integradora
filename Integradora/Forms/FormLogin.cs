using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UniKino.Programacion.ProyectoIntegrador.Forms;

namespace UniKino.Programacion.ProyectoIntegrador.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Falta el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNameTextBox.Focus();
            }
            else if (PasswordTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Falta el password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTextBox.Focus();
            }
            else
            {
                if (Datos.ValidarUsuario(UserNameTextBox.Text, PasswordTextBox.Text))
                {
                    // verify this  

                    Datos.UsuarioActual = UserNameTextBox.Text;
                    this.DialogResult = DialogResult.OK;

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PasswordTextBox.Focus();
                }
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.UserNameTextBox.Text = "Gaby";
            PasswordTextBox.Text = "123";
        }
    }
}

