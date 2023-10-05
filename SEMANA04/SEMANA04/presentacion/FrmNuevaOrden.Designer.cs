namespace SEMANA04.presentacion
{
    partial class FrmNuevaOrden
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            dgvOrdenes = new DataGridView();
            colMaterial = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colAcciones = new DataGridViewButtonColumn();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtResponsable = new TextBox();
            dtpFecha = new DateTimePicker();
            btnAgregar = new Button();
            nupCantidad = new NumericUpDown();
            cboMateriales = new ComboBox();
            label3 = new Label();
            chbSeguir = new CheckBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupCantidad).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 28);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 64);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(76, 15);
            label2.TabIndex = 1;
            label2.Text = "Responsable:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dgvOrdenes
            // 
            dgvOrdenes.AllowUserToAddRows = false;
            dgvOrdenes.AllowUserToDeleteRows = false;
            dgvOrdenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenes.Columns.AddRange(new DataGridViewColumn[] { colMaterial, colStock, colCantidad, colAcciones });
            dgvOrdenes.Location = new Point(12, 153);
            dgvOrdenes.Name = "dgvOrdenes";
            dgvOrdenes.ReadOnly = true;
            dgvOrdenes.RowTemplate.Height = 25;
            dgvOrdenes.Size = new Size(622, 247);
            dgvOrdenes.TabIndex = 2;
            dgvOrdenes.CellContentClick += dgvOrdenes_CellContentClick;
            // 
            // colMaterial
            // 
            colMaterial.HeaderText = "MATERIAL";
            colMaterial.Name = "colMaterial";
            colMaterial.ReadOnly = true;
            colMaterial.Width = 200;
            // 
            // colStock
            // 
            colStock.HeaderText = "STOCK";
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            colStock.Width = 140;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "CANTIDAD";
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            colCantidad.Width = 140;
            // 
            // colAcciones
            // 
            colAcciones.HeaderText = "ACCIONES";
            colAcciones.Name = "colAcciones";
            colAcciones.ReadOnly = true;
            colAcciones.Width = 96;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(214, 480);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(89, 35);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(326, 480);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(89, 35);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtResponsable
            // 
            txtResponsable.Location = new Point(112, 61);
            txtResponsable.Name = "txtResponsable";
            txtResponsable.Size = new Size(344, 23);
            txtResponsable.TabIndex = 5;
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(112, 22);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(124, 23);
            dtpFecha.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(460, 101);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(142, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // nupCantidad
            // 
            nupCantidad.Location = new Point(330, 100);
            nupCantidad.Name = "nupCantidad";
            nupCantidad.Size = new Size(105, 23);
            nupCantidad.TabIndex = 9;
            // 
            // cboMateriales
            // 
            cboMateriales.FormattingEnabled = true;
            cboMateriales.Location = new Point(19, 100);
            cboMateriales.Name = "cboMateriales";
            cboMateriales.Size = new Size(285, 23);
            cboMateriales.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(480, 64);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 12;
            label3.Text = "Seguir cargando";
            // 
            // chbSeguir
            // 
            chbSeguir.AutoSize = true;
            chbSeguir.Location = new Point(574, 65);
            chbSeguir.Name = "chbSeguir";
            chbSeguir.Size = new Size(15, 14);
            chbSeguir.TabIndex = 13;
            chbSeguir.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(chbSeguir);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtResponsable);
            groupBox1.Controls.Add(cboMateriales);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(nupCantidad);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Location = new Point(12, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(622, 146);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // FrmNuevaOrden
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 540);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(dgvOrdenes);
            Name = "FrmNuevaOrden";
            Text = "Registrar orden de retiro";
            Load += FrmNuevaOrden_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupCantidad).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvOrdenes;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtResponsable;
        private DateTimePicker dtpFecha;
        private Button btnAgregar;
        private NumericUpDown nupCantidad;
        private ComboBox cboMateriales;
        private DataGridViewTextBoxColumn colMaterial;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewButtonColumn colAcciones;
        private Label label3;
        private CheckBox chbSeguir;
        private GroupBox groupBox1;
    }
}