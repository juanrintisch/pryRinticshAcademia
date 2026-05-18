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
    
    
    

    public partial class frmInicio : Form
    {
        public DateTime varIncioSesion = DateTime.Now;

        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {           
           
            varIncioSesion = DateTime.Now;
            frmRegistro frmRegistro = new frmRegistro();
            this.Hide();
            frmRegistro.ShowDialog();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            this.Size = new Size(289, 216);
        }
    }
}
