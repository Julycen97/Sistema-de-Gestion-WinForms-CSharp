namespace Vistas
{
    partial class frmAltaArticulo
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtImagenes = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.btnVerImagen = new System.Windows.Forms.Button();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAceptar.Location = new System.Drawing.Point(210, 606);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(174, 44);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(88, 83);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(95, 25);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "CODIGO";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(78, 150);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(104, 25);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(26, 217);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(155, 25);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "DESCRIPCION";
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(96, 285);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(88, 25);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "MARCA";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(48, 352);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(134, 25);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "CATEGORIA";
            // 
            // lblImagen
            // 
            this.lblImagen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(60, 419);
            this.lblImagen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(122, 25);
            this.lblImagen.TabIndex = 6;
            this.lblImagen.Text = "IMAGENES";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(92, 533);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(91, 25);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "PRECIO";
            // 
            // cboMarca
            // 
            this.cboMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(210, 271);
            this.cboMarca.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(356, 33);
            this.cboMarca.TabIndex = 8;
            // 
            // cboCategoria
            // 
            this.cboCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(210, 340);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(356, 33);
            this.cboCategoria.TabIndex = 9;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.Location = new System.Drawing.Point(210, 69);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(356, 31);
            this.txtCodigo.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(210, 137);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(356, 31);
            this.txtNombre.TabIndex = 11;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(210, 204);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(356, 31);
            this.txtDescripcion.TabIndex = 12;
            // 
            // txtImagenes
            // 
            this.txtImagenes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImagenes.Location = new System.Drawing.Point(210, 410);
            this.txtImagenes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtImagenes.Name = "txtImagenes";
            this.txtImagenes.Size = new System.Drawing.Size(356, 31);
            this.txtImagenes.TabIndex = 13;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecio.Location = new System.Drawing.Point(210, 523);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(356, 31);
            this.txtPrecio.TabIndex = 14;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Location = new System.Drawing.Point(396, 606);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(174, 44);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pbxImagen
            // 
            this.pbxImagen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImagen.Location = new System.Drawing.Point(672, 73);
            this.pbxImagen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(662, 577);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 16;
            this.pbxImagen.TabStop = false;
            // 
            // btnVerImagen
            // 
            this.btnVerImagen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVerImagen.Location = new System.Drawing.Point(210, 463);
            this.btnVerImagen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnVerImagen.Name = "btnVerImagen";
            this.btnVerImagen.Size = new System.Drawing.Size(108, 44);
            this.btnVerImagen.TabIndex = 17;
            this.btnVerImagen.Text = "Ver";
            this.btnVerImagen.UseVisualStyleBackColor = true;
            this.btnVerImagen.Click += new System.EventHandler(this.btnVerImagen_Click);
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarImagen.Location = new System.Drawing.Point(446, 463);
            this.btnAgregarImagen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(124, 44);
            this.btnAgregarImagen.TabIndex = 18;
            this.btnAgregarImagen.Text = "Agregar";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(330, 463);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(104, 44);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 673);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.btnVerImagen);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtImagenes);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnAceptar);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1548, 744);
            this.MinimumSize = new System.Drawing.Size(1368, 683);
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar articulo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtImagenes;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Button btnVerImagen;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Button btnLimpiar;
    }
}