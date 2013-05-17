using System;
using System.Windows.Forms;

namespace UniKino.Programacion.ProyectoIntegrador.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ButtonOk_Click(object sender, EventArgs e)
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

    }
}

