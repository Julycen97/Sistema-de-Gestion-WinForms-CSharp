using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Vistas
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulos;

        public frmArticulos()
        {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargar();
        }
        
        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulos = negocio.ObtenerDatos();
                dgvArticulos.DataSource = listaArticulos;
                ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo frmAltaArticulo = new frmAltaArticulo();
            frmAltaArticulo.ShowDialog();

            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    
        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["CodArt"].Visible = false;

        }
    }

}
