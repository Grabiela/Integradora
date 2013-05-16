using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

                        this.Hide();
                        Datos.UsuarioActual = UserNameTextBox.Text;
                        new FormMain().Show();
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

