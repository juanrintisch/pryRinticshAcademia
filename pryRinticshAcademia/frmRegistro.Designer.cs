namespace pryRinticshAcademia
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblActivo = new System.Windows.Forms.Label();
            this.mskCodigo = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbPlan = new System.Windows.Forms.ComboBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.btnListado = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
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
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(12, 19);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(40, 13);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(12, 87);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(28, 13);
            this.lblPlan.TabIndex = 2;
            this.lblPlan.Text = "Plan";
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Location = new System.Drawing.Point(12, 121);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(37, 13);
            this.lblActivo.TabIndex = 3;
            this.lblActivo.Text = "Activo";
            // 
            // mskCodigo
            // 
            this.mskCodigo.Location = new System.Drawing.Point(88, 16);
            this.mskCodigo.Mask = "99999";
            this.mskCodigo.Name = "mskCodigo";
            this.mskCodigo.Size = new System.Drawing.Size(39, 20);
            this.mskCodigo.TabIndex = 4;
            this.mskCodigo.ValidatingType = typeof(int);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(88, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // cmbPlan
            // 
            this.cmbPlan.FormattingEnabled = true;
            this.cmbPlan.Location = new System.Drawing.Point(88, 84);
            this.cmbPlan.Name = "cmbPlan";
            this.cmbPlan.Size = new System.Drawing.Size(121, 21);
            this.cmbPlan.TabIndex = 6;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(88, 121);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(15, 14);
            this.chkActivo.TabIndex = 7;
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnListado
            // 
            this.btnListado.BackColor = System.Drawing.Color.LightBlue;
            this.btnListado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListado.Location = new System.Drawing.Point(12, 158);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(75, 23);
            this.btnListado.TabIndex = 8;
            this.btnListado.Text = "Listado";
            this.btnListado.UseVisualStyleBackColor = false;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(168, 158);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.LightGreen;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(249, 158);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
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
            this.grpBuscar.Location = new System.Drawing.Point(12, 198);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(231, 156);
            this.grpBuscar.TabIndex = 11;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar";
            // 
            // cmbPlanDos
            // 
            this.cmbPlanDos.FormattingEnabled = true;
            this.cmbPlanDos.Location = new System.Drawing.Point(76, 113);
            this.cmbPlanDos.Name = "cmbPlanDos";
            this.cmbPlanDos.Size = new System.Drawing.Size(121, 21);
            this.cmbPlanDos.TabIndex = 12;
            // 
            // txtNombreDos
            // 
            this.txtNombreDos.Location = new System.Drawing.Point(76, 81);
            this.txtNombreDos.Name = "txtNombreDos";
            this.txtNombreDos.Size = new System.Drawing.Size(121, 20);
            this.txtNombreDos.TabIndex = 12;
            // 
            // mskCodigoDos
            // 
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
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 371);
            this.Controls.Add(this.grpBuscar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnListado);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.cmbPlan);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.mskCodigo);
            this.Controls.Add(this.lblActivo);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblcodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro - Materia";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.MaskedTextBox mskCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbPlan;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.TextBox txtNombreDos;
        private System.Windows.Forms.MaskedTextBox mskCodigoDos;
        private System.Windows.Forms.RadioButton rdoNombre;
        private System.Windows.Forms.RadioButton rdoPlan;
        private System.Windows.Forms.RadioButton rdoCodigo;
        private System.Windows.Forms.RadioButton rdoTodo;
        private System.Windows.Forms.ComboBox cmbPlanDos;
    }
}