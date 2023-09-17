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
        private List<Articulo> listaArticulos = new List<Articulo>();

        public frmArticulos()
        {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargar();

            //ITEMS DEL CAMPO FILTRO AVANZADO
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoria");
            cboCampo.Items.Add("Precio");
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
            Articulo articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmAltaArticulo frmAltaArticulo = new frmAltaArticulo(articulo);

            frmAltaArticulo.ShowDialog();

            cargar();
        }
    
        //QUE RECIBA UN STRING Y LO PONGA NO VISIBLE (LLAMAR PARA OCULTAR POR COLUMNA)
        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;

            dgvArticulos.Columns["CodArt"].Visible = false;

        }

        //VENTANA VER DETALLE 
        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmDetalleArticulo verDetalle = new frmDetalleArticulo(seleccionado);

            verDetalle.ShowDialog();
        }

        //FILTRO SIMPLE
        private void txtFiltrarSimple_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;

            string filtro = txtFiltrarSimple.Text;

            if (filtro.Length >= 2)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.CodArt.ToUpper().Contains(filtro.ToUpper()) || x.MarcaArt.NombreMarca.ToUpper().Contains(filtro.ToUpper()) || x.CategoriaArt.NombreCategoria.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;

            ocultarColumnas();
        }

        //FILTRO AVANZADO
        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();

            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        //FILTRO AVANZADO
        private void btnFiltrarAvanzado_Click(object sender, EventArgs e)
        {
            if (cboCampo.SelectedItem == null || cboCriterio.SelectedItem == null)
            {
                MessageBox.Show("Error: Debes seleccionar campos y criterios válidos.");
                return;
            }

            if (string.IsNullOrEmpty(txtFiltrarAvanzado.Text) || txtFiltrarAvanzado.Text == null)
            {
                return;

            }
         
            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (!float.TryParse(txtFiltrarAvanzado.Text, out float resultado))
                {
                    MessageBox.Show("Error: El campo 'Precio' debe ser un número válido.");

                    return; 
                }
            }

            try
            {
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltrarAvanzado.Text;

                ArticuloNegocio negocio = new ArticuloNegocio();

                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void eliminar()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            Articulo articulo;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Estás seguro que deseas eliminarlo?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                
                if (respuesta == DialogResult.Yes)
                {
                    articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                    articuloNegocio.EliminarDatos(articulo.ID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                cargar();
            }
        }

        private void btnLimpiarFiltroAvanzado_Click(object sender, EventArgs e)
        {
            txtFiltrarAvanzado.Text = "";
            cargar();
        }
    }
}

