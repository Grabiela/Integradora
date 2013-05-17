using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UniKino.Programacion.ProyectoIntegrador.Models;

namespace UniKino.Programacion.ProyectoIntegrador.Forms
{
    public partial class FormCaja : Form
    {
        Random r = new Random();
        int temporal = 0;

        List<Producto> _productos = new List<Producto>();

        public FormCaja()
        {
            InitializeComponent();
        }

        private void caja_Load(object sender, EventArgs e)
        {
            Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid.AllowUserToDeleteRows = true;
            Grid.DataSource = new BindingList<Producto>(_productos);

            Grid.Columns["Imagen"].Visible = false;

            // toolStripStatusLabel1.Text = "Hora: " + DateTime.Now.ToLongTimeString() + "  " + "Fecha: " + DateTime.Now.ToLongDateString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Valida solo numeros
            // backspace = 8
            // enter = 13
            // esc 27

            // cancelacoin del ultimo producto
            if (e.KeyChar == 27)
            {
                if (Grid.Rows.Count > 0)
                {
                    Grid.Rows.RemoveAt(Grid.Rows.Count - 1);
                }

            }


            if (char.IsDigit(e.KeyChar) | e.KeyChar == 8 | e.KeyChar == '*' | e.KeyChar == 13)
            {
                //ya vimos que es numero backspace y *
                // validar uno y solo un *

                //MessageBox.Show(textBox1.Text.IndexOf('*') + "");

                if (ProductoText.Text.IndexOf('*') > 0 & e.KeyChar == '*')
                {
                    e.Handled = true;
                }
                else
                {
                    // que no empiece el * en el lugar 0
                    if (ProductoText.Text.Trim() == "" & e.KeyChar == '*')
                    {
                        e.Handled = true;
                    }

                }

                // termino de validar el *

                if (e.KeyChar == 13 && ProductoText.Text.Trim() != "")
                {

                    String[] m = ProductoText.Text.Split('*');

                    if (m.Length == 1)
                    {
                        temporal = r.Next(1, 1001);



                        for (int i = 0; i <= Datos.Productos.GetUpperBound(0); i++)
                        {

                            if (m[0].ToString() == Datos.Productos[i, 0].ToString())
                            {
                                Grid.Rows.Add("1", Datos.Productos[i, 1].ToString(), Datos.Productos[i, 2].ToString(), Datos.Productos[i, 2].ToString());
                            }
                        }

                    }
                    else
                    {
                        temporal = r.Next(1, 1001);
                        for (int i = 0; i <= Datos.Productos.GetUpperBound(0); i++)
                        {

                            if (m[1].ToString() == Datos.Productos[i, 0].ToString())
                            {
                                Grid.Rows.Add(m[0], Datos.Productos[i, 1].ToString(), Datos.Productos[i, 2].ToString(),
                                    (double.Parse(Datos.Productos[i, 2].ToString()) * double.Parse(m[0])).ToString());
                                try
                                {
                                    ImageProduct.Image = (Bitmap)Image.FromFile(Datos.Productos[i, 3].ToString());
                                }
                                catch (Exception Error)
                                {
                                }
                            }
                        }



                    }
                    ProductoText.Clear();
                    ProductoText.Focus();
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // toolStripStatusLabel1.Text = "Hora: " + DateTime.Now.ToLongTimeString() + "Fecha: " + DateTime.Now.ToLongDateString();

        }

        private void ProductoText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                AgregarProducto();
                Grid.DataSource = new BindingList<Producto>(_productos);
            }

        }

        private void AgregarProducto()
        {
            var texto = ProductoText.Text.Trim();
            if (texto.Length > 0)
            {
                int cantidad;
                int codigo = 0;
                string descripcion = string.Empty;

                var partes = texto.Split(new char[] { '*' });

                cantidad = int.Parse(partes[0]);
                if (!int.TryParse(partes[1], out codigo))
                {
                    descripcion = partes[1];
                }

                Producto producto = codigo == 0
                    ? Datos.BuscarProducto(descripcion)
                    : Datos.BuscarProducto(codigo.ToString());

                if (producto == null)
                {
                    MessageBox.Show("No lo encotre");
                    return;
                }

                producto.Cantidad = cantidad;

                _productos.Add(producto);

                ProductoText.Text = string.Empty;

                TotalLabel.Text = String.Format("TOTAL: {0:C}", _productos.Sum(x => x.Subtotal));
            }
        }
    }
}
