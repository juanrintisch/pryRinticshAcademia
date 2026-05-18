using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRinticshAcademia
{

    public partial class frmRegistro : Form
    {

        public DateTime varIncioSesion;

        int varCodigo;
        string varNombre;
        string varPlan;
        bool varActivo;

        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            frmListado frmListado = new frmListado();
            this.Hide();
            frmListado.ShowDialog();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            this.Size = new Size(351, 249);
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.varIncioSesion = DateTime.Now;
            lblIncioSesion.Text = frmRegistro.varIncioSesion.ToString();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            

            if (mskCodigo.Text=="")
            {
                MessageBox.Show("Ingrese un Codigo", "Registro - Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskCodigo.Focus();
            }
            else if (txtNombre.Text=="")
            {
                MessageBox.Show("Ingrese un Nombre", "Registro - Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Focus();
            }
            else if (cmbPlan.SelectedIndex==-1)
            {
                MessageBox.Show("Seleccione un Plan", "Registro - Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}
