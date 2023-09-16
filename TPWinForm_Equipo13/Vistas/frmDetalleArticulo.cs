using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class frmDetalleArticulo : Form
    {
        private Articulo articulo = null;
        private bool banderaImg = true;
        private int indiceImg = 0;
        
        public frmDetalleArticulo()
        {
            InitializeComponent();
        }

        public frmDetalleArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmDetalleArticulo_Load(object sender, EventArgs e)            // FALTA QUE SE CARGUEN LAS IMG
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
                pbImagen.Load(articulo.ImagenArt[0].URLImagen);

            }
            catch (WebException)
            {
                pbImagen.Load("https://images.assetsdelivery.com/compings_v2/pavelstasevich/pavelstasevich1811/pavelstasevich181101028.jpg");

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
