namespace pryRinticshAcademia
{
    partial class frmCargaPlanes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaPlanes));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblPlan = new System.Windows.Forms.Label();
            this.txtNombrePlan = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lstPlanes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(190, 55);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(76, 28);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(12, 32);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(87, 13);
            this.lblPlan.TabIndex = 1;
            this.lblPlan.Text = "Nombre Del Plan";
            // 
            // txtNombrePlan
            // 
            this.txtNombrePlan.Location = new System.Drawing.Point(105, 29);
            this.txtNombrePlan.Name = "txtNombrePlan";
            this.txtNombrePlan.Size = new System.Drawing.Size(161, 20);
            this.txtNombrePlan.TabIndex = 2;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.LightBlue;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(105, 55);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(76, 27);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lstPlanes
            // 
            this.lstPlanes.FormattingEnabled = true;
            this.lstPlanes.Location = new System.Drawing.Point(15, 108);
            this.lstPlanes.Name = "lstPlanes";
            this.lstPlanes.Size = new System.Drawing.Size(251, 95);
            this.lstPlanes.TabIndex = 4;
            // 
            // frmCargaPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 234);
            this.Controls.Add(this.lstPlanes);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtNombrePlan);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.btnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCargaPlanes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCargaPlanes";
            this.Load += new System.EventHandler(this.frmCargaPlanes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.TextBox txtNombrePlan;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ListBox lstPlanes;
    }
}