using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Forms
{
    public partial class FormMain : Form
    {
        private FormUsuarios _formUsuarios;
        private FormProductos _formProductos;
        private FormCaja _formCaja;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_formUsuarios == null)
                _formUsuarios = new FormUsuarios();
            _formUsuarios.MdiParent = this;
            _formUsuarios.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_formProductos == null)
                _formProductos = new FormProductos();
            _formProductos.MdiParent = this;
            _formProductos.Show();
        }

        private void cajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_formCaja == null)
            _formCaja = new FormCaja();
            _formCaja.MdiParent = this;
            _formCaja.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
