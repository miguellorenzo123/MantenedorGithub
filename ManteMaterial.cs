using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantenedorGithub
{
    public partial class ManteMaterial : Form
    {
        public ManteMaterial()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            //int indice = cmbDistribuidor.SelectedIndex;
            listBox1.Items.Add("---------------------------\n");
            listBox1.Items.Add("Nombre: " + txtNombre.Text);
            listBox1.Items.Add("Cantidad: " + txtCantidad.Text);
            listBox1.Items.Add("Descripcion : " + txtDescripcion.Text);
            listBox1.Items.Add("Distribuidor: " + cmbDistribuidor.SelectedItem.ToString());


            txtNombre.Clear();
            txtCantidad.Clear();
            txtDescripcion.Clear();
        }
    }
}
