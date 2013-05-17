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
                var row = Grid.Rows[Grid.SelectedCells[0].RowIndex];

                // Renglones seleccionados

                CodeLabel.Text = "Código: " + row.Cells[0].Value.ToString();
                NombreLabel.Text = "Nombre: " + row.Cells[1].Value.ToString();
                PrecioLabel.Text = "Precio: " + row.Cells[2].Value.ToString();
                ImageBox2.Image = (Bitmap)Image.FromFile(Datos.UbicacionDeLaImagen(row.Cells[3].Value.ToString()));

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
                Grid.Rows.Add(Datos.Productos[i, 0], Datos.Productos[i, 1], Datos.Productos[i, 2], Datos.Productos[i, 3]);
                
                Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ImageBox_Click(object sender, EventArgs e)
        {

        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
