using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRinticshAcademia
{
    public partial class frmListado : Form
    {

        

        public frmListado()
        {
            InitializeComponent();
        }

        private void frmListado_Load(object sender, EventArgs e)
        {

        }

        private void grpBuscar_Enter(object sender, EventArgs e)
        {
            

        }

        private void rdoCodigo_CheckedChanged(object sender, EventArgs e)
        {
           
            if (rdoCodigo.Checked == true)
            {
                mskCodigoDos.Enabled = true;
            }
            else
            {
                mskCodigoDos.Enabled = false;
            }

        }

        private void rdoNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNombre.Checked == true)
            {
                txtNombreDos.Enabled = true;
            }
            else
            {
                txtNombreDos.Enabled = false;
            }
        }

        private void rdoPlan_CheckedChanged(object sender, EventArgs e)
        {

            if (rdoPlan.Checked == true)
            {
                cmbPlanDos.Enabled = true;
            }
            else
            {
                cmbPlanDos.Enabled = false;
            }

        }

        private void rdoTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTodo.Checked == true)
            {
                mskCodigoDos.Enabled = true;
                txtNombreDos.Enabled = true;
                cmbPlanDos.Enabled = true;
            }
            else
            {
                mskCodigoDos.Enabled = false;
                txtNombreDos.Enabled = false;
                cmbPlanDos.Enabled = false;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            this.Hide();
            frmRegistro.ShowDialog();
        }
    }
}
