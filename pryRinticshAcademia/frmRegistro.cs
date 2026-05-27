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

        int i = 0;
        string[,] matMaterias = new string[2,5];

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
            else
            {
                MessageBox.Show("Registro Exitoso" + "\nCodigo: " + mskCodigo.Text + "\nNombre: " + txtNombre.Text + "\nPlan: " + cmbPlan.SelectedItem.ToString(), "Registro - Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //varCodigo = Convert.ToInt32(mskCodigo.Text);
            //varNombre = txtNombre.Text;
            //varPlan = cmbPlan.SelectedItem.ToString();

            matMaterias[i,0] = mskCodigo.Text;
            matMaterias[i,1] = txtNombre.Text;
            matMaterias[i,2] = cmbPlan.SelectedItem.ToString();
            

            if (chkActivo.Checked == true)
            {
                matMaterias[i,3] = "Activo";
                varActivo = true;
                i++;
            }
            else
            {
                matMaterias[i,3] = "Inactivo";
                varActivo = false;
                i++;
            }
            if (i >= matMaterias.GetLength(0))
            {
                MessageBox.Show("Registro Lleno", "Registro - Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRegistrar.Enabled = false;
            }


            mskCodigo.Clear();
            txtNombre.Clear();
            cmbPlan.SelectedIndex = -1;
            chkActivo.Checked = false;
            mskCodigo.Focus();

        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            frmCargaPlanes frmCargaPlanes = new frmCargaPlanes();
            this.Hide();
            frmCargaPlanes.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
