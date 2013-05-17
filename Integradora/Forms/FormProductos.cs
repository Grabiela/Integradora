using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace UniKino.Programacion.ProyectoIntegrador.Forms
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];

                // Renglones seleccionados

                CodeLabel.Text = "Código: " + row.Cells[0].Value.ToString();
                NombreLabel.Text = "Nombre: " + row.Cells[1].Value.ToString();
                PrecioLabel.Text = "Precio: " + row.Cells[2].Value.ToString();
                ImageBox2.Image = (Bitmap)Image.FromFile(Datos.GetImagePath(row.Cells[3].Value.ToString()));

            }
            catch (Exception Error)
            {

                //Quita cualquier imagen al picture box
                ImageBox2.Image = null;
            }
        }

        private void productos_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= Datos.Productos.GetUpperBound(0); i++)
            {
                dataGridView1.Rows.Add(Datos.Productos[i, 0], Datos.Productos[i, 1], Datos.Productos[i, 2], Datos.Productos[i, 3]);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ImageBox_Click(object sender, EventArgs e)
        {

        }
    }
}
