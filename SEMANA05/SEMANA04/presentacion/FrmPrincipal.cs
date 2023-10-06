using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEMANA04.presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void nuevaOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevaOrden nvaOrden = new FrmNuevaOrden();
            nvaOrden.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "Control",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Exclamation) == DialogResult.Yes)
                this.Close();
        }

        private void reporteMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteMateriales rptateriales = new FrmReporteMateriales();
            rptateriales.ShowDialog();
        }
    }
}
