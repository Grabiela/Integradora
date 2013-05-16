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
                // Renglones seleccionados
                //MessageBox.Show(dataGridView1.SelectedCells[0].RowIndex + "");
                label2.Text = "Código: " + dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                label3.Text = "Nombre: " + dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
                label4.Text = "Precio: " + dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
                pictureBox1.Image = (Bitmap)Image.FromFile(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[3].Value.ToString());

            }
            catch (Exception Error)
            {

                //Quita cualquier imagen al picture box
                pictureBox1.Image = null;
            }
        }

        private void productos_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <=Datos.Productos.GetUpperBound(0); i++)
            {
                dataGridView1.Rows.Add(Datos.Productos[i, 0],Datos.Productos[i, 1],Datos.Productos[i, 2],Datos.Productos[i, 3]);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
