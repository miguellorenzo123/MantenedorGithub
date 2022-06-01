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
    public partial class ManteEmpleado : Form
    {
        public ManteEmpleado()
        {
            InitializeComponent();

        }

      

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtapellido.Text = "";
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtsector.Text = "";
            txtresultado.Text = "";
        }

        private void btnaplicar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("codigo: " + txtcodigo.Text);
            listBox1.Items.Add("nombre: " + txtnombre.Text);
            listBox1.Items.Add("apellido : " + txtapellido.Text);
            listBox1.Items.Add("sector: " + txtsector.Text);

            txtresultado.Text = "empleado registrado con exito";
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
