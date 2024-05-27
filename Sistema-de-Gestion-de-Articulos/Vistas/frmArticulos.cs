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
        //ATRIBUTO PARA RECIBIR TODOS LOS ART
        private List<Articulo> listaArticulos = new List<Articulo>();

        public frmArticulos()
        {
            InitializeComponent();
        }

        //PAGE LOAD
        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargarArticulos();

            //ITEMS DEL CAMPO FILTRO AVANZADO
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoria");
            cboCampo.Items.Add("Precio");
        }

        //CARGAR ART
        private void cargarArticulos()
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

        //OCULTAR COLUMNAS ART
        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;

            dgvArticulos.Columns["CodArt"].Visible = false;

        }

        //AGREGAR ART
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaModificacionArticulo frmAltaArt = new frmAltaModificacionArticulo();

            frmAltaArt.ShowDialog();

            cargarArticulos();
        }

        //MODIFICAR ART
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                frmAltaModificacionArticulo frmModificarArt = new frmAltaModificacionArticulo(articulo);

                frmModificarArt.ShowDialog();

                cargarArticulos();
            }
        }
    
        //VER DETALLE ART
        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                frmDetalleArticulo verDetalle = new frmDetalleArticulo(seleccionado);

                verDetalle.ShowDialog();
            }
        }

        //ELIMINAR ART
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                eliminarArticulo();
            }
        }

        //ELIMINAR ART
        private void eliminarArticulo()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            Articulo articulo;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Estás seguro que deseas eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

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
                cargarArticulos();
            }
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

            if (string.IsNullOrEmpty(txtFiltrarAvanzado.Text))
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


        //LIMPIAR FILTRO
        private void btnLimpiarFiltroAvanzado_Click(object sender, EventArgs e)
        {
            txtFiltrarAvanzado.Text = "";
            cargarArticulos();
        }
    }
}

