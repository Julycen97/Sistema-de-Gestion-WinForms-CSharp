﻿using Dominio;
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
    public partial class frmAltaModificacionArticulo : Form
    {
        //ATRIBUTO PARA RECIBIR UN ART (MODIFICAR)
        //CREAR UN ARTICULO (AGREGAR)
        private Articulo articulo = null;
        //ATRIBUTO PARA CARGAR IMAGENES A ART
        private Imagen imagen = new Imagen();
        //ATRIBUTO PARA LECIBIR TODAS LAS IMG DE UN ART
        private List<Imagen> imagenes = new List<Imagen>();

        public frmAltaModificacionArticulo()
        {
            InitializeComponent();
        }

        //CTOR. CON ART COMO PARAMETRO (MODIFICAR)
        public frmAltaModificacionArticulo(Articulo articulo)
        {
            InitializeComponent();

            this.articulo = articulo;

            Text = "Modificar Articulo";
        }

        //PAGE LOAD
        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            //BOTON AGREGAR NO VISIBLE HASTA QUE SE CARGUE UNA IMAGEN VALIDA
            btnAgregarImagen.Enabled = false;

            try
            {
                //OBTIENE MARCAS
                cboMarca.DataSource = marcaNegocio.ObtenerDatos();
                cboMarca.ValueMember = "IdMarca";
                cboMarca.DisplayMember = "NombreMarca";

                //OBTIENE CATEGORIAS
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

        //VER IMAGEN
        private void btnVerImagen_Click(object sender, EventArgs e)
        {
            try
            {
                pbxImagen.Load(txtImagenes.Text);

                //HACE VISIBLE EL BOTON AGREGAR SI LA IMAGEN ES VALIDA
                btnAgregarImagen.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("La imagen proporcionada no es valida ...");
                pbxImagen.Load("https://images.assetsdelivery.com/compings_v2/pavelstasevich/pavelstasevich1811/pavelstasevich181101028.jpg");
            }
        }

        //AGREGAR IMAGEN (CHEQUEO)
        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            ImagenNegocio imgNeg = new ImagenNegocio();

            try
            {
                pbxImagen.Load(txtImagenes.Text);

                if (articulo != null)
                {
                    imagen.IdArt = articulo.ID;
                    imagen.URLImagen = txtImagenes.Text;

                    imgNeg.Agregar_ModificarDatos(imagen, true);

                    MessageBox.Show("Imagen agregada al articulo ID: " + articulo.ID);

                    txtImagenes.Text = string.Empty;

                    //HACE NO VISIBLE EL BOTON AGREGAR SI CARGO BIEN LA IMAGEN
                    btnAgregarImagen.Enabled = false;
                }
                else
                {
                    imagen = new Imagen();
                    //ASIGNA URL PARA CUANDO PRESIONE ACEPTAR CARGUE TODAS LAS IMAGENES
                    //EN EL EVENTO DEL CLICK_BTNACEPTAR
                    imagen.URLImagen = txtImagenes.Text;

                    //CARGA LA LISTA PARA AGREGAR AL ARTICULO EN EVENTO CLICK_BTNACEPTAR
                    imagenes.Add(imagen);

                    txtImagenes.Text = string.Empty;

                    MessageBox.Show("Imagen agregada !");

                    //HACE NO VISIBLE EL BOTON AGREGAR SI CARGO BIEN LA IMAGEN
                    btnAgregarImagen.Enabled = false;
                }
            }
            catch (Exception)
            {
                txtImagenes.Text = string.Empty;

                pbxImagen.Load("https://images.assetsdelivery.com/compings_v2/pavelstasevich/pavelstasevich1811/pavelstasevich181101028.jpg");
                MessageBox.Show("Error al cargar la imagen");

                //HACE NO VISIBLE EL BOTON AGREGAR SI CARGO BIEN LA IMAGEN
                btnAgregarImagen.Enabled = false;
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

                        int idArticulo = idUltimoArt();

                        foreach (Imagen item in imagenes)
                        {
                            item.IdArt = idArticulo;
                        }

                        foreach (Imagen item in imagenes)
                        {
                            imgNeg.Agregar_ModificarDatos(item, esAgregar);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Registro modificado exitosamente!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Alguno de los campos están sin datos");
                }
            }

            Close();
        }

        //LIMPIAR CAJA DE TEXTO PARA AGREGAR IMG
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtImagenes.Text = "";
            btnAgregarImagen.Enabled = false;
            pbxImagen.Image = null;
        }

        //CERRAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
