using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class frmDetalleArticulo : Form
    {
        private Articulo articulo = null;
        
        public frmDetalleArticulo()
        {
            InitializeComponent();
        }

        public frmDetalleArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmDetalleArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                txtCodigo.Text = articulo.CodArt.ToString();
                txtNombre.Text = articulo.NombreArt.ToString();
                txtMarca.Text = articulo.MarcaArt.ToString();
                txtDescripcion.Text = articulo.DescripcionArt.ToString();
                txtCategoria.Text = articulo.CategoriaArt.ToString();
                txtPrecio.Text = articulo.PrecioArt.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
