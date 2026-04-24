namespace WindowsFormsApp
{
    partial class frmMarcas
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgregarAceptar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 0;
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Location = new System.Drawing.Point(69, 45);
            this.lblMarcas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(45, 16);
            this.lblMarcas.TabIndex = 2;
            this.lblMarcas.Text = "Marca";
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarcas.Location = new System.Drawing.Point(65, 109);
            this.dgvMarcas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowHeadersWidth = 51;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(204, 185);
            this.dgvMarcas.TabIndex = 6;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(65, 302);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(204, 28);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(65, 73);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(204, 28);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 409);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAgregarAceptar
            // 
            this.btnAgregarAceptar.Location = new System.Drawing.Point(65, 373);
            this.btnAgregarAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarAceptar.Name = "btnAgregarAceptar";
            this.btnAgregarAceptar.Size = new System.Drawing.Size(204, 28);
            this.btnAgregarAceptar.TabIndex = 9;
            this.btnAgregarAceptar.Text = "Agregar";
            this.btnAgregarAceptar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 43);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 22);
            this.textBox1.TabIndex = 8;
            // 
            // frmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 462);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregarAceptar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvMarcas);
            this.Controls.Add(this.lblMarcas);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Marcas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAgregarAceptar;
        private System.Windows.Forms.TextBox textBox1;
    }
}