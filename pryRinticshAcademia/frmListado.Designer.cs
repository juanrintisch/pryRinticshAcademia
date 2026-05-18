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
            this.grpBuscar.SuspendLayout();
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
            this.grpBuscar.Size = new System.Drawing.Size(231, 156);
            this.grpBuscar.TabIndex = 12;
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
            this.cmbPlanDos.TabIndex = 12;
            // 
            // txtNombreDos
            // 
            this.txtNombreDos.Enabled = false;
            this.txtNombreDos.Location = new System.Drawing.Point(76, 81);
            this.txtNombreDos.Name = "txtNombreDos";
            this.txtNombreDos.Size = new System.Drawing.Size(121, 20);
            this.txtNombreDos.TabIndex = 12;
            // 
            // mskCodigoDos
            // 
            this.mskCodigoDos.Enabled = false;
            this.mskCodigoDos.Location = new System.Drawing.Point(76, 49);
            this.mskCodigoDos.Mask = "99999";
            this.mskCodigoDos.Name = "mskCodigoDos";
            this.mskCodigoDos.Size = new System.Drawing.Size(39, 20);
            this.mskCodigoDos.TabIndex = 12;
            this.mskCodigoDos.ValidatingType = typeof(int);
            // 
            // rdoNombre
            // 
            this.rdoNombre.AutoSize = true;
            this.rdoNombre.Location = new System.Drawing.Point(6, 82);
            this.rdoNombre.Name = "rdoNombre";
            this.rdoNombre.Size = new System.Drawing.Size(68, 17);
            this.rdoNombre.TabIndex = 3;
            this.rdoNombre.TabStop = true;
            this.rdoNombre.Text = "Nombre";
            this.rdoNombre.UseVisualStyleBackColor = true;
            // 
            // rdoPlan
            // 
            this.rdoPlan.AutoSize = true;
            this.rdoPlan.Location = new System.Drawing.Point(6, 114);
            this.rdoPlan.Name = "rdoPlan";
            this.rdoPlan.Size = new System.Drawing.Size(50, 17);
            this.rdoPlan.TabIndex = 2;
            this.rdoPlan.TabStop = true;
            this.rdoPlan.Text = "Plan";
            this.rdoPlan.UseVisualStyleBackColor = true;
            // 
            // rdoCodigo
            // 
            this.rdoCodigo.AutoSize = true;
            this.rdoCodigo.Location = new System.Drawing.Point(6, 50);
            this.rdoCodigo.Name = "rdoCodigo";
            this.rdoCodigo.Size = new System.Drawing.Size(64, 17);
            this.rdoCodigo.TabIndex = 1;
            this.rdoCodigo.TabStop = true;
            this.rdoCodigo.Text = "Codigo";
            this.rdoCodigo.UseVisualStyleBackColor = true;
            // 
            // rdoTodo
            // 
            this.rdoTodo.AutoSize = true;
            this.rdoTodo.Location = new System.Drawing.Point(6, 19);
            this.rdoTodo.Name = "rdoTodo";
            this.rdoTodo.Size = new System.Drawing.Size(54, 17);
            this.rdoTodo.TabIndex = 0;
            this.rdoTodo.TabStop = true;
            this.rdoTodo.Text = "Todo";
            this.rdoTodo.UseVisualStyleBackColor = true;
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 191);
            this.Controls.Add(this.grpBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro - Listado";
            this.Load += new System.EventHandler(this.frmListado_Load);
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
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
    }
}