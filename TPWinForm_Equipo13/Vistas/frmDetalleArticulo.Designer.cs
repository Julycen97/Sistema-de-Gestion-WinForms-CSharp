namespace Vistas
{
    partial class frmDetalleArticulo
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
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnImagenAnterior = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnImagenSiguiente = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagen
            // 
            this.pbImagen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagen.Location = new System.Drawing.Point(754, 75);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(694, 552);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVolver.Location = new System.Drawing.Point(366, 583);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(150, 44);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnImagenAnterior
            // 
            this.btnImagenAnterior.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnImagenAnterior.Location = new System.Drawing.Point(296, 408);
            this.btnImagenAnterior.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnImagenAnterior.Name = "btnImagenAnterior";
            this.btnImagenAnterior.Size = new System.Drawing.Size(150, 44);
            this.btnImagenAnterior.TabIndex = 32;
            this.btnImagenAnterior.Text = "<";
            this.btnImagenAnterior.UseVisualStyleBackColor = true;
            this.btnImagenAnterior.Click += new System.EventHandler(this.btnImagenAnterior_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecio.Location = new System.Drawing.Point(244, 473);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(418, 31);
            this.txtPrecio.TabIndex = 31;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(246, 206);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(418, 31);
            this.txtDescripcion.TabIndex = 29;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(246, 140);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(418, 31);
            this.txtNombre.TabIndex = 28;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.Location = new System.Drawing.Point(244, 75);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(418, 31);
            this.txtCodigo.TabIndex = 27;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(126, 485);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(91, 25);
            this.lblPrecio.TabIndex = 24;
            this.lblPrecio.Text = "PRECIO";
            // 
            // lblImagen
            // 
            this.lblImagen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(94, 417);
            this.lblImagen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(122, 25);
            this.lblImagen.TabIndex = 23;
            this.lblImagen.Text = "IMAGENES";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(82, 350);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(134, 25);
            this.lblCategoria.TabIndex = 22;
            this.lblCategoria.Text = "CATEGORIA";
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(130, 283);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(88, 25);
            this.lblMarca.TabIndex = 21;
            this.lblMarca.Text = "MARCA";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(60, 215);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(155, 25);
            this.lblDescripcion.TabIndex = 20;
            this.lblDescripcion.Text = "DESCRIPCION";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(112, 148);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(104, 25);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(122, 81);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(95, 25);
            this.lblCodigo.TabIndex = 18;
            this.lblCodigo.Text = "CODIGO";
            // 
            // btnImagenSiguiente
            // 
            this.btnImagenSiguiente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnImagenSiguiente.Location = new System.Drawing.Point(468, 408);
            this.btnImagenSiguiente.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnImagenSiguiente.Name = "btnImagenSiguiente";
            this.btnImagenSiguiente.Size = new System.Drawing.Size(148, 44);
            this.btnImagenSiguiente.TabIndex = 33;
            this.btnImagenSiguiente.Text = ">";
            this.btnImagenSiguiente.UseVisualStyleBackColor = true;
            this.btnImagenSiguiente.Click += new System.EventHandler(this.btnImagenSiguiente_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMarca.Location = new System.Drawing.Point(244, 271);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(418, 31);
            this.txtMarca.TabIndex = 34;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoria.Location = new System.Drawing.Point(246, 337);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(418, 31);
            this.txtCategoria.TabIndex = 35;
            // 
            // frmDetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 675);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.btnImagenSiguiente);
            this.Controls.Add(this.btnImagenAnterior);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pbImagen);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1708, 746);
            this.MinimumSize = new System.Drawing.Size(1442, 659);
            this.Name = "frmDetalleArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle";
            this.Load += new System.EventHandler(this.frmDetalleArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnImagenAnterior;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnImagenSiguiente;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtCategoria;
    }
}