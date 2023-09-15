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

            if (articulo == null)
            {
                articulo = new Articulo();
                esAgregar = true;
                articulo.CodArt = txtCodigo.Text;
                articulo.DescripcionArt = txtDescripcion.Text;
                articulo.NombreArt = txtNombre.Text;
                //articulo.MarcaArt = (Marca)cboMarca.SelectedItem;
                //articulo.CategoriaArt = (Categoria)cboCategoria.SelectedItem;

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
            //MarcaNegocio marcaNegocio = new MarcaNegocio();
            //CaregoriaNegocio categoriaNegocio = new CategoriaNegocio();
            //cboMarca.DataSource = MarcaNegocio
            //cboMarca.ValueMember = "Id"
            //cboMarca.DisplayMember = "Descripcion"
            //cboCategoria.DataSource = CategoriaNegocio
            //cboCategoria.ValueMember = "Id"
            //cboCategoria.DisplayMember = "Descripcion"
        }
    }
}
