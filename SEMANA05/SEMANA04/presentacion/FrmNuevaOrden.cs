using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SEMANA04.dominio;
using SEMANA04.datos;
using SEMANA04.servicios.Implementacion;
using SEMANA04.servicios.Interfaz;

namespace SEMANA04.presentacion
{
    public partial class FrmNuevaOrden : Form
    {

        //Dependencias
        IServicio servicio = null;
        OrdenRetiro nuevo = null;

        public FrmNuevaOrden()
        {
            InitializeComponent();
            servicio = new Servicio(new FactoryDao());
            nuevo = new OrdenRetiro();
        }
        private void FrmNuevaOrden_Load(object sender, EventArgs e)
        {
            //Cargar combos en el cboMateriales
            CargarCombos();
        }
        private void CargarCombos()
        {
            List<Material> listMaterial = servicio.TraerMaterial();
            cboMateriales.DataSource = listMaterial;
            cboMateriales.ValueMember = "Codigo";
            cboMateriales.DisplayMember = "Nombre";
            cboMateriales.SelectedIndex = -1;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Se validan si los campos no estan vacios
            if (string.IsNullOrEmpty(txtResponsable.Text))
            {
                MessageBox.Show("Debe ingresar un responsable", "Control", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (cboMateriales.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un material", "Control", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (nupCantidad.Value <= 0)
            {
                MessageBox.Show("Debe ingresar una cantidad", "Control", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            foreach (DataGridViewRow fila in dgvOrdenes.Rows)
            {
                if (fila.Cells["colMaterial"].Value.ToString() == cboMateriales.Text)
                {
                    MessageBox.Show("Ya esta este material en uso", "Control", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
            }
            Material m = (Material)cboMateriales.SelectedItem;

            int cant = (int)nupCantidad.Value;

            DetalleOrden ordenDetalle = new DetalleOrden(m, cant);
            nuevo.AgregarDetalle(ordenDetalle);

            dgvOrdenes.Rows.Add(new object[] { m.Nombre, m.Stock, cant, "Quitar" });
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            nuevo.Responsable = txtResponsable.Text;
            CargarOrdenes();
        }
        private void CargarOrdenes()
        {
            if (servicio.CrearOrdenRetiro(nuevo))
            {
                MessageBox.Show("Se cargo la/s orden/es con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (chbSeguir.Checked)
                    Vaciar();
                else
                    this.Dispose();
            }
            else
                MessageBox.Show("No se pudo cargar la orden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void Vaciar()
        {
            dgvOrdenes.Rows.Clear();
            txtResponsable.Text = string.Empty;
            cboMateriales.SelectedIndex = -1;
            nupCantidad.Value = 0;
        }
        private void dgvOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrdenes.CurrentCell.ColumnIndex == 3)
            {
                //Primero quitar detalle de objeto nuevo porque de lo contrario al quitar un elemento
                //de dgvOrdenes, Current.Row quedara null
                nuevo.QuitarDetalle(dgvOrdenes.CurrentRow.Index);
                dgvOrdenes.Rows.RemoveAt(dgvOrdenes.CurrentRow.Index);
            }
        }
    }
}
