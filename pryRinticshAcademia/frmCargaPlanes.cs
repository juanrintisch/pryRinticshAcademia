using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace pryRinticshAcademia
{
    public partial class frmCargaPlanes : Form
    {

        string[] arrayPlan = new string[4];
        int varIndice = 0;  

        public frmCargaPlanes()
        {
            InitializeComponent();
        }

        private void frmCargaPlanes_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (txtNombrePlan.Text == "")
            {
                MessageBox.Show("Por Favor Ingrese un Plan", "Carga Planes - Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
            else if (txtNombrePlan.Text != "")
            {
                arrayPlan[varIndice] = txtNombrePlan.Text;
                varIndice++;
                txtNombrePlan.Clear();
                MessageBox.Show("Plan Agregado con Exito", "Carga Planes - Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (varIndice >= arrayPlan.Length)
                {
                    txtNombrePlan.Enabled = false;
                    btnAgregar.Enabled = false;
                }
                txtNombrePlan.Focus();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arrayPlan.Length; i++)
            {
                lstPlanes.Items.Add(arrayPlan[i]);
            }
        }
    }
}
