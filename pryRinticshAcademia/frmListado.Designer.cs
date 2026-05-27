namespace pryRinticshAcademia
{
    partial class frmListado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListado));
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.cmbPlanDos = new System.Windows.Forms.ComboBox();
            this.txtNombreDos = new System.Windows.Forms.TextBox();
            this.mskCodigoDos = new System.Windows.Forms.MaskedTextBox();
            this.rdoNombre = new System.Windows.Forms.RadioButton();
            this.rdoPlan = new System.Windows.Forms.RadioButton();
            this.rdoCodigo = new System.Windows.Forms.RadioButton();
            this.rdoTodo = new System.Windows.Forms.RadioButton();
            this.dtaMaterias = new System.Windows.Forms.DataGridView();
            this.columnaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.cmbPlanDos);
            this.grpBuscar.Controls.Add(this.txtNombreDos);
            this.grpBuscar.Controls.Add(this.mskCodigoDos);
            this.grpBuscar.Controls.Add(this.rdoNombre);
            this.grpBuscar.Controls.Add(this.rdoPlan);
            this.grpBuscar.Controls.Add(this.rdoCodigo);
            this.grpBuscar.Controls.Add(this.rdoTodo);
            this.grpBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBuscar.Location = new System.Drawing.Point(12, 12);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(231, 159);
            this.grpBuscar.TabIndex = 0;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar";
            this.grpBuscar.Enter += new System.EventHandler(this.grpBuscar_Enter);
            // 
            // cmbPlanDos
            // 
            this.cmbPlanDos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanDos.Enabled = false;
            this.cmbPlanDos.FormattingEnabled = true;
            this.cmbPlanDos.Items.AddRange(new object[] {
            "a",
            "b",
            "c"});
            this.cmbPlanDos.Location = new System.Drawing.Point(76, 113);
            this.cmbPlanDos.Name = "cmbPlanDos";
            this.cmbPlanDos.Size = new System.Drawing.Size(121, 21);
            this.cmbPlanDos.TabIndex = 0;
            // 
            // txtNombreDos
            // 
            this.txtNombreDos.Enabled = false;
            this.txtNombreDos.Location = new System.Drawing.Point(76, 81);
            this.txtNombreDos.Name = "txtNombreDos";
            this.txtNombreDos.Size = new System.Drawing.Size(121, 20);
            this.txtNombreDos.TabIndex = 5;
            // 
            // mskCodigoDos
            // 
            this.mskCodigoDos.Enabled = false;
            this.mskCodigoDos.Location = new System.Drawing.Point(76, 49);
            this.mskCodigoDos.Mask = "99999";
            this.mskCodigoDos.Name = "mskCodigoDos";
            this.mskCodigoDos.Size = new System.Drawing.Size(39, 20);
            this.mskCodigoDos.TabIndex = 3;
            this.mskCodigoDos.ValidatingType = typeof(int);
            // 
            // rdoNombre
            // 
            this.rdoNombre.AutoSize = true;
            this.rdoNombre.Location = new System.Drawing.Point(6, 82);
            this.rdoNombre.Name = "rdoNombre";
            this.rdoNombre.Size = new System.Drawing.Size(68, 17);
            this.rdoNombre.TabIndex = 4;
            this.rdoNombre.TabStop = true;
            this.rdoNombre.Text = "Nombre";
            this.rdoNombre.UseVisualStyleBackColor = true;
            this.rdoNombre.CheckedChanged += new System.EventHandler(this.rdoNombre_CheckedChanged);
            // 
            // rdoPlan
            // 
            this.rdoPlan.AutoSize = true;
            this.rdoPlan.Location = new System.Drawing.Point(6, 114);
            this.rdoPlan.Name = "rdoPlan";
            this.rdoPlan.Size = new System.Drawing.Size(50, 17);
            this.rdoPlan.TabIndex = 6;
            this.rdoPlan.TabStop = true;
            this.rdoPlan.Text = "Plan";
            this.rdoPlan.UseVisualStyleBackColor = true;
            this.rdoPlan.CheckedChanged += new System.EventHandler(this.rdoPlan_CheckedChanged);
            // 
            // rdoCodigo
            // 
            this.rdoCodigo.AutoSize = true;
            this.rdoCodigo.Location = new System.Drawing.Point(6, 50);
            this.rdoCodigo.Name = "rdoCodigo";
            this.rdoCodigo.Size = new System.Drawing.Size(64, 17);
            this.rdoCodigo.TabIndex = 2;
            this.rdoCodigo.TabStop = true;
            this.rdoCodigo.Text = "Codigo";
            this.rdoCodigo.UseVisualStyleBackColor = true;
            this.rdoCodigo.CheckedChanged += new System.EventHandler(this.rdoCodigo_CheckedChanged);
            // 
            // rdoTodo
            // 
            this.rdoTodo.AutoSize = true;
            this.rdoTodo.Location = new System.Drawing.Point(6, 19);
            this.rdoTodo.Name = "rdoTodo";
            this.rdoTodo.Size = new System.Drawing.Size(54, 17);
            this.rdoTodo.TabIndex = 1;
            this.rdoTodo.TabStop = true;
            this.rdoTodo.Text = "Todo";
            this.rdoTodo.UseVisualStyleBackColor = true;
            this.rdoTodo.CheckedChanged += new System.EventHandler(this.rdoTodo_CheckedChanged);
            // 
            // dtaMaterias
            // 
            this.dtaMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaCodigo,
            this.columnaNombre,
            this.columnaPlan,
            this.columnaActivo});
            this.dtaMaterias.Location = new System.Drawing.Point(249, 12);
            this.dtaMaterias.Name = "dtaMaterias";
            this.dtaMaterias.Size = new System.Drawing.Size(444, 159);
            this.dtaMaterias.TabIndex = 1;
            // 
            // columnaCodigo
            // 
            this.columnaCodigo.HeaderText = "Codigo";
            this.columnaCodigo.Name = "columnaCodigo";
            this.columnaCodigo.ReadOnly = true;
            // 
            // columnaNombre
            // 
            this.columnaNombre.HeaderText = "Nombre";
            this.columnaNombre.Name = "columnaNombre";
            this.columnaNombre.ReadOnly = true;
            // 
            // columnaPlan
            // 
            this.columnaPlan.HeaderText = "Plan";
            this.columnaPlan.Name = "columnaPlan";
            this.columnaPlan.ReadOnly = true;
            // 
            // columnaActivo
            // 
            this.columnaActivo.HeaderText = "Activo";
            this.columnaActivo.Name = "columnaActivo";
            this.columnaActivo.ReadOnly = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(13, 178);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 213);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dtaMaterias);
            this.Controls.Add(this.grpBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro - Listado";
            this.Load += new System.EventHandler(this.frmListado_Load);
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaMaterias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.ComboBox cmbPlanDos;
        private System.Windows.Forms.TextBox txtNombreDos;
        private System.Windows.Forms.MaskedTextBox mskCodigoDos;
        private System.Windows.Forms.RadioButton rdoNombre;
        private System.Windows.Forms.RadioButton rdoPlan;
        private System.Windows.Forms.RadioButton rdoCodigo;
        private System.Windows.Forms.RadioButton rdoTodo;
        private System.Windows.Forms.DataGridView dtaMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaActivo;
        private System.Windows.Forms.Button btnVolver;
    }
}