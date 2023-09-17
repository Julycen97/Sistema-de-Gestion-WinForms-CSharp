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
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;

        private Imagen imagen = new Imagen();

        private List<Imagen> imagenes = new List<Imagen>();                 // NUEVO PARA AGREGAR MUCHAS IMAGENES

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

        //ID DEL ULTIMO ARTICULO CARGADO PARA CARGAR IMAGEN
        private int idUltimoArt()
        {
            AccesoDatos dato = new AccesoDatos();
            int id = 0;

            try
            {
                dato.SetearConsulta("SELECT TOP 1 Id FROM ARTICULOS ORDER BY Id DESC");
                dato.AbrirConexionEjecutarConsulta();

                while (dato.Lector.Read())
                {
                    id = (int)dato.Lector["Id"];
                }

                return id;
            }
            catch(Exception)
            {
                return 0;
            }
            finally
            {
                dato.CerrarConexion();
            }
        }

        //CERRAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //CARGA DE PAGINA AL APARECER
        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            //BOTON AGREGAR NO VISIBLE HASTA QUE SE CARGUE UNA IMAGEN VALIDA
            //btnAgregarImagen.Visible = false;

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
                    txtNombre.Text = articulo.NombreArt;
                    txtDescripcion.Text = articulo.DescripcionArt;
                    cboMarca.SelectedValue = articulo.MarcaArt.IdMarca;
                    cboCategoria.SelectedValue = articulo.CategoriaArt.IdCategoria;
                    txtPrecio.Text = articulo.PrecioArt.ToString();

                    try
                    {
                        pbxImagen.Load(articulo.ImagenArt[0].URLImagen);
                    }
                    catch (Exception)
                    {
                        //SI NO PUEDE CARGA UNA POR DEFECTO
                        pbxImagen.Load("https://images.assetsdelivery.com/compings_v2/pavelstasevich/pavelstasevich1811/pavelstasevich181101028.jpg");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //VER IMAGEN
        private void btnVerImagen_Click(object sender, EventArgs e)
        {
            try
            {
                pbxImagen.Load(txtImagenes.Text);

                //HACE VISIBLE EL BOTON AGREGAR SI LA IMAGEN ES VALIDA
                btnAgregarImagen.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("La imagen proporcionada no es valida ...");
                pbxImagen.Load("https://images.assetsdelivery.com/compings_v2/pavelstasevich/pavelstasevich1811/pavelstasevich181101028.jpg");
            }
        }

        //AGREGAR IMAGEN (CHEQUEO)
        private void btnAgregarImagen_Click(object sender, EventArgs e)          // NUEVO PARA AGREGAR MULTIPLES IMG
        {
            ImagenNegocio imgNeg = new ImagenNegocio();

            if (articulo != null)
            {
                imagen.IdArt = articulo.ID;
                imagen.URLImagen = txtImagenes.Text;               

                imgNeg.Agregar_ModificarDatos(imagen, true);

                MessageBox.Show("Imagen agregada al articulo ID: " + articulo.ID);

                txtImagenes.Text = string.Empty;

                //HACE NO VISIBLE EL BOTON AGREGAR SI CARGO BIEN LA IMAGEN
                //btnAgregarImagen.Visible = false;
            }
            else
            {
                //ASIGNA URL PARA CUANDO PRESIONE ACEPTAR CARGUE TODAS LAS IMAGENES
                //EN EL EVENTO DEL CLICK_BTNACEPTAR
                Imagen nuevaImg = new Imagen();
                nuevaImg.URLImagen = txtImagenes.Text;

                //CARGA LA LISTA PARA AGREGAR AL ARTICULO EN EVENTO CLICK_BTNACEPTAR
                imagenes.Add(nuevaImg);
            }
        }

        //EVENTO SE LANZA AL PRESIONAR TECLA EN TEXTBOX
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //SOLO ADMITE NUMEROS
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        //ACEPTAR
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool esAgregar = true;
            ArticuloNegocio artNeg = new ArticuloNegocio();
            ImagenNegocio imgNeg = new ImagenNegocio();

            if (string.IsNullOrEmpty(txtCodigo.Text) ||
                 string.IsNullOrEmpty(txtDescripcion.Text) ||
                 string.IsNullOrEmpty(txtNombre.Text) ||
                  string.IsNullOrEmpty(txtPrecio.Text) ||
                  !float.TryParse(txtPrecio.Text, out float precio))
            {
                MessageBox.Show("Error: Todos los campos deben completarse con datos válidos");

                return;
            }
            else
            {
                try
                {
                    if (articulo == null)
                    {
                        esAgregar = true;
                        articulo = new Articulo();
                    }
                    else
                    {
                        esAgregar = false;
                    }

                    articulo.CodArt = txtCodigo.Text;
                    articulo.DescripcionArt = txtDescripcion.Text;
                    articulo.NombreArt = txtNombre.Text;
                    articulo.MarcaArt = (Marca)cboMarca.SelectedItem;
                    articulo.CategoriaArt = (Categoria)cboCategoria.SelectedItem;
                    articulo.PrecioArt = decimal.Parse(txtPrecio.Text);

                    artNeg.Agregar_ModificarDatos(articulo, esAgregar);

                    if (esAgregar)
                    {
                        MessageBox.Show("Registro agregado exitosamente!");

                        //imagen.IdArt = idUltimoArt();                             // comentado para agregar multiples img

                        int idArticulo = idUltimoArt();

                        foreach (Imagen item in imagenes)                                        // NUEVO PARA CARGAR MULTIPLES IMAGENES agrega idarticulo a cada obj de la lista
                        {
                            item.IdArt = idArticulo;
                        }

                        //imagen.URLImagen = txtImagenes.Text;                      // comentado para agregar multiples img

                        foreach (Imagen item in imagenes)                                   // NUEVO PARA CARGAR MULTIPLES IMAGENES agrega la lista item por item (nose si es la mejor forma pero si la hacemos andar puede ir)
                        {
                            imgNeg.Agregar_ModificarDatos(item, esAgregar);
                        }

                        //imgNeg.Agregar_ModificarDatos(imagen, esAgregar);         // comentado para agregar multiples imagenes
                    }
                    else
                    {
                        MessageBox.Show("Registro modificado exitosamente!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtImagenes.Text = "";
        }
    }
}
