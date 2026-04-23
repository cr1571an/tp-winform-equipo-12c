namespace WindowsFormsApp
{
    partial class frmArticulos
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
            this.dataGridArticulos = new System.Windows.Forms.DataGridView();
            this.btnVer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridArticulos
            // 
            this.dataGridArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridArticulos.Location = new System.Drawing.Point(9, 76);
            this.dataGridArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridArticulos.Name = "dataGridArticulos";
            this.dataGridArticulos.RowHeadersWidth = 51;
            this.dataGridArticulos.RowTemplate.Height = 24;
            this.dataGridArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridArticulos.Size = new System.Drawing.Size(554, 288);
            this.dataGridArticulos.TabIndex = 0;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(12, 386);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 1;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.dataGridArticulos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArticulos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridArticulos;
        private System.Windows.Forms.Button btnVer;
    }
}