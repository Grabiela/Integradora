﻿using System;
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
            GridUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            GridUsuarios.DataSource = new BindingList<Usuario>(Datos.Usuarios);
        }

        private void GridUsuarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var user = GridUsuarios.Rows[e.RowIndex].DataBoundItem as Usuario;
            if (user != null)
            {
                UsernameLabel.Text = user.Username;
                PasswordLabel.Text = user.Password;
                ImageBox.ImageLocation = String.Format(@"C:\Users\Gabriela\Downloads\images\{0}", user.Image);
            }
        }
    }
}
