using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UniKino.Programacion.ProyectoIntegrador.Models;

namespace UniKino.Programacion.ProyectoIntegrador.Forms
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void usuarios_Load(object sender, EventArgs e)
        {
            Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Grid.DataSource = new BindingList<User>(Datos.Usuarios);
        }

        private void GridUsuarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var user = Grid.Rows[e.RowIndex].DataBoundItem as User;
            if (user != null)
            {
                UsernameLabel.Text = user.UserName;
                PasswordLabel.Text = user.Password;
                ImageBox.ImageLocation = String.Format(@"C:\Users\Gabriela\Downloads\images\{0}", user.Image);
            }
        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
