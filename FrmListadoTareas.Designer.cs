namespace E2
{
    partial class FrmListadoTareas
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
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnNuevaTarea = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCompletada = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.Location = new System.Drawing.Point(12, 20);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(100, 18);
            this.lblFiltrar.TabIndex = 0;
            this.lblFiltrar.Text = "Filtrar Estado:";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(118, 17);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(196, 26);
            this.cboEstado.TabIndex = 1;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(320, 12);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(107, 43);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // btnNuevaTarea
            // 
            this.btnNuevaTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaTarea.Location = new System.Drawing.Point(636, 12);
            this.btnNuevaTarea.Name = "btnNuevaTarea";
            this.btnNuevaTarea.Size = new System.Drawing.Size(146, 35);
            this.btnNuevaTarea.TabIndex = 3;
            this.btnNuevaTarea.Text = "NUEVA TAREA";
            this.btnNuevaTarea.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(770, 344);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnCompletada
            // 
            this.btnCompletada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompletada.Location = new System.Drawing.Point(632, 434);
            this.btnCompletada.Name = "btnCompletada";
            this.btnCompletada.Size = new System.Drawing.Size(150, 70);
            this.btnCompletada.TabIndex = 5;
            this.btnCompletada.Text = "MARCAR COMO COMPLETADA";
            this.btnCompletada.UseVisualStyleBackColor = true;
            // 
            // FrmListadoTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 516);
            this.Controls.Add(this.btnCompletada);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNuevaTarea);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.lblFiltrar);
            this.Name = "FrmListadoTareas";
            this.Text = "FrmListadoTareas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnNuevaTarea;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCompletada;
    }
}