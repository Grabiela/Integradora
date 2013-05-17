using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UniKino.Programacion.ProyectoIntegrador.Forms
{
    public partial class FormMain : Form
    {
        #region fields
        private FormUsuarios _formUsuarios;
        private FormProductos _formProductos;
        private FormCaja _formCaja;
        #endregion

        #region FormMain
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            MenuSesion_Click(MenuSesion, new EventArgs());
        }
        #endregion

        #region Menus

        private void MenuUsuarios_Click(object sender, EventArgs e)
        {
            if (_formUsuarios == null)
                _formUsuarios = new FormUsuarios();

            _formUsuarios.Disposed += (se, ev) => { _formUsuarios = null; };

            _formUsuarios.MdiParent = this;
            _formUsuarios.Show();
        }

        private void MenuProductos_Click(object sender, EventArgs e)
        {
            if (_formProductos == null)
                _formProductos = new FormProductos();

            _formProductos.Disposed += (se, ev) => { _formProductos = null; };

            _formProductos.MdiParent = this;
            _formProductos.Show();
        }

        private void MenuCaja_Click(object sender, EventArgs e)
        {
            if (_formCaja == null)
                _formCaja = new FormCaja();

            _formCaja.Disposed += (se, ev) => { _formCaja = null; };

            _formCaja.MdiParent = this;
            _formCaja.Show();
        }

        private void MenuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuSesion_Click(object sender, EventArgs e)
        {
            var result = DialogResult.Cancel;

            if (MenuSesion.Text.Equals("Iniciar Sesión"))
            {
                result = new FormLogin().ShowDialog();
            }

            ActualizarUsuario(result);
        }

        #endregion

        private void ActualizarUsuario(DialogResult result)
        {
            if (result == DialogResult.OK)
            {
                StatusBarUsuario.Text = "Usuario: " + Datos.UsuarioActual;
                MenuSesion.Text = "Cerrar Sesion";
                MenuUsuarios.Enabled = true;
                MenuCaja.Enabled = true;
                MenuProductos.Enabled = true;
            }
            else
            {
                StatusBarUsuario.Text = "Sesion no iniciada";
                MenuSesion.Text = "Iniciar Sesión";
                Datos.UsuarioActual = string.Empty;
                MenuUsuarios.Enabled = false;
                MenuCaja.Enabled = false;
                MenuProductos.Enabled = false;

            }


        }
    }
}
