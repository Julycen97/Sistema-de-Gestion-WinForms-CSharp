namespace Vistas
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.lblFiltrarAvanzado = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.txtFiltrarAvanzado = new System.Windows.Forms.TextBox();
            this.txtFiltrarSimple = new System.Windows.Forms.TextBox();
            this.lblFiltrarSimple = new System.Windows.Forms.Label();
            this.btnFiltrarAvanzado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(414, 112);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(6);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersWidth = 82;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(1284, 1063);
            this.dgvArticulos.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(78, 112);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(242, 44);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(78, 167);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(6);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(242, 44);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(78, 223);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(242, 44);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.Location = new System.Drawing.Point(78, 279);
            this.btnVerDetalle.Margin = new System.Windows.Forms.Padding(6);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(242, 44);
            this.btnVerDetalle.TabIndex = 4;
            this.btnVerDetalle.Text = "Ver Detalle";
            this.btnVerDetalle.UseVisualStyleBackColor = true;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // lblFiltrarAvanzado
            // 
            this.lblFiltrarAvanzado.AutoSize = true;
            this.lblFiltrarAvanzado.Location = new System.Drawing.Point(90, 627);
            this.lblFiltrarAvanzado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFiltrarAvanzado.Name = "lblFiltrarAvanzado";
            this.lblFiltrarAvanzado.Size = new System.Drawing.Size(224, 25);
            this.lblFiltrarAvanzado.TabIndex = 5;
            this.lblFiltrarAvanzado.Text = "BUSCAR ARTICULOS";
            // 
            // cboCampo
            // 
            this.cboCampo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboCampo.Location = new System.Drawing.Point(84, 679);
            this.cboCampo.Margin = new System.Windows.Forms.Padding(6);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(238, 33);
            this.cboCampo.TabIndex = 6;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(84, 733);
            this.cboCriterio.Margin = new System.Windows.Forms.Padding(6);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(238, 33);
            this.cboCriterio.TabIndex = 7;
            // 
            // txtFiltrarAvanzado
            // 
            this.txtFiltrarAvanzado.Location = new System.Drawing.Point(84, 787);
            this.txtFiltrarAvanzado.Margin = new System.Windows.Forms.Padding(6);
            this.txtFiltrarAvanzado.Name = "txtFiltrarAvanzado";
            this.txtFiltrarAvanzado.Size = new System.Drawing.Size(238, 31);
            this.txtFiltrarAvanzado.TabIndex = 8;
            // 
            // txtFiltrarSimple
            // 
            this.txtFiltrarSimple.Location = new System.Drawing.Point(84, 513);
            this.txtFiltrarSimple.Margin = new System.Windows.Forms.Padding(6);
            this.txtFiltrarSimple.Name = "txtFiltrarSimple";
            this.txtFiltrarSimple.Size = new System.Drawing.Size(238, 31);
            this.txtFiltrarSimple.TabIndex = 9;
            this.txtFiltrarSimple.TextChanged += new System.EventHandler(this.txtFiltrarSimple_TextChanged);
            // 
            // lblFiltrarSimple
            // 
            this.lblFiltrarSimple.AutoSize = true;
            this.lblFiltrarSimple.Location = new System.Drawing.Point(88, 471);
            this.lblFiltrarSimple.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFiltrarSimple.Name = "lblFiltrarSimple";
            this.lblFiltrarSimple.Size = new System.Drawing.Size(224, 25);
            this.lblFiltrarSimple.TabIndex = 10;
            this.lblFiltrarSimple.Text = "FILTRAR ARTICULOS";
            // 
            // btnFiltrarAvanzado
            // 
            this.btnFiltrarAvanzado.Location = new System.Drawing.Point(84, 837);
            this.btnFiltrarAvanzado.Margin = new System.Windows.Forms.Padding(6);
            this.btnFiltrarAvanzado.Name = "btnFiltrarAvanzado";
            this.btnFiltrarAvanzado.Size = new System.Drawing.Size(242, 44);
            this.btnFiltrarAvanzado.TabIndex = 11;
            this.btnFiltrarAvanzado.Text = "Buscar";
            this.btnFiltrarAvanzado.UseVisualStyleBackColor = true;
            this.btnFiltrarAvanzado.Click += new System.EventHandler(this.btnFiltrarAvanzado_Click);
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1810, 1262);
            this.Controls.Add(this.btnFiltrarAvanzado);
            this.Controls.Add(this.lblFiltrarSimple);
            this.Controls.Add(this.txtFiltrarSimple);
            this.Controls.Add(this.txtFiltrarAvanzado);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.lblFiltrarAvanzado);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvArticulos);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.Label lblFiltrarAvanzado;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.TextBox txtFiltrarAvanzado;
        private System.Windows.Forms.TextBox txtFiltrarSimple;
        private System.Windows.Forms.Label lblFiltrarSimple;
        private System.Windows.Forms.Button btnFiltrarAvanzado;
    }
}