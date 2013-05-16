using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void usuarios_Load(object sender, EventArgs e)
        {

            toolStripStatusLabel1.Text = "Usuario: " + Datos.UsuarioActual;

            GridUsuarios.DataSource = new BindingList<User>(Datos.Usuarios);

            // viejo
            dataGridView1.Visible = false;


            for (int i = 0; i <= Datos.Usuarios_original.GetLength(0) - 1; i++)
            {
                dataGridView1.Rows.Add(Datos.Usuarios_original[i, 0], Datos.Usuarios_original[i, 1], Datos.Usuarios_original[i, 2]);
            }
        }

        private void GridUsuarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var user = GridUsuarios.Rows[e.RowIndex].DataBoundItem as User;
            if (user != null)
            {
                UsernameLabel.Text = user.UserName;
                PasswordLabel.Text = user.Password;
                ImageBox.ImageLocation = String.Format(@"C:\Users\Gabriela\Downloads\images\{0}", user.Image);
            }
        }

    }
}
