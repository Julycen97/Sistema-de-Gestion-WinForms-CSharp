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
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;

        private Imagen imagen = null;

        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool esAgregar = true;
            ArticuloNegocio artNeg = new ArticuloNegocio();
            ImagenNegocio imgNeg = new ImagenNegocio();

            if (articulo == null)
            {
                articulo = new Articulo();
                esAgregar = true;
                articulo.CodArt = txtCodigo.Text;
                articulo.DescripcionArt = txtDescripcion.Text;
                articulo.NombreArt = txtNombre.Text;
                articulo.MarcaArt = (Marca)cboMarca.SelectedItem;
                articulo.CategoriaArt = (Categoria)cboCategoria.SelectedItem;
                // falta mandar imagen
                
                
            }
            else
            {
                esAgregar = false;
                


            }

            try
            {
                artNeg.Agregar_ModificarDatos(articulo,esAgregar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            ArticuloNegocio artNeg = new ArticuloNegocio();
                   
            try
            {
                cboMarca.DataSource = marcaNegocio.ObtenerDatos();
                cboMarca.ValueMember = "IdMarca";
                cboMarca.DisplayMember = "NombreMarca";

                cboCategoria.DataSource = categoriaNegocio.ObtenerDatos();
                cboCategoria.ValueMember = "IdCategoria";
                cboCategoria.DisplayMember = "NombreCategoria";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.CodArt;
                    txtDescripcion.Text = articulo.DescripcionArt;
                    txtNombre.Text = articulo.NombreArt;
                    cboMarca.SelectedValue = articulo.MarcaArt.IdMarca;
                    cboCategoria.SelectedValue = articulo.CategoriaArt.IdCategoria;
                    txtPrecio.Text = articulo.PrecioArt.ToString();
                    // falta precargar una imagen
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            try
            {
            pbxImagen.Load(txtImagenes.Text);

            }
            catch (Exception)
            {
            pbxImagen.Load("https://images.assetsdelivery.com/compings_v2/pavelstasevich/pavelstasevich1811/pavelstasevich181101028.jpg");
            }
        }

    }
}
