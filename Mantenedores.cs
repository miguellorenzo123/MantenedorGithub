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
    public partial class FormMantenedores : Form
    {
        public FormMantenedores()
        {
            InitializeComponent();

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ManteEmpleado mEmpleado = new ManteEmpleado();
            mEmpleado.Show();
        }

        private void btnDiseno_Click(object sender, EventArgs e)
        {
            ManteDiseno mDiseno = new ManteDiseno();
            mDiseno.Show();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            ManteMaterial mMaterial = new ManteMaterial();
            mMaterial.Show();
        }

        private void btnDistribuidor_Click(object sender, EventArgs e)
        {
            ManteDistribuidor mDistribuidor = new ManteDistribuidor();
            mDistribuidor.Show();
        }

        private void btnJefe_Click(object sender, EventArgs e)
        {
            ManteJefe mJefe = new ManteJefe();
            mJefe.Show();
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            ManteHerramientas mHerramientas = new ManteHerramientas();
            mHerramientas.Show();
        }

        private void btnPlano_Click(object sender, EventArgs e)
        {
            MantePlanos mPlanos = new MantePlanos();
            mPlanos.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMantenedores_Load(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            cn.abrir();
        }
    }
}
