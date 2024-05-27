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
        //ATRIBUTO PARA RECIBIR UN ART
        private Articulo articulo = null;
        //ATRIBUTO PARA PASAR LAS IMAGENES
        private int indiceImg = 0;
        
        public frmDetalleArticulo()
        {
            InitializeComponent();
        }

        //PAGE LOAD
        public frmDetalleArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        //DETALLE DEL ART
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
            catch (Exception)
            {
                //IMAGEN POR DEFECTO
                pbImagen.Load("https://images.assetsdelivery.com/compings_v2/pavelstasevich/pavelstasevich1811/pavelstasevich181101028.jpg");
            }
        }

        //VOLVER
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        //PASAR IMAGEN
        private void btnImagenSiguiente_Click(object sender, EventArgs e)
        {
            int cantidad = articulo.ImagenArt.Count();

            if(indiceImg == 0)
            {
                indiceImg ++;

                try
                {
                    pbImagen.Load(articulo.ImagenArt[indiceImg].URLImagen);
                }
                catch (Exception)
                {
                    pbImagen.Load("https://images.assetsdelivery.com/compings_v2/pavelstasevich/pavelstasevich1811/pavelstasevich181101028.jpg");
                }

                indiceImg ++;
            }
            else if(indiceImg < cantidad)
            {
                try
                {
                    pbImagen.Load(articulo.ImagenArt[indiceImg].URLImagen);
                }
                catch (Exception)
                {
                    pbImagen.Load("https://images.assetsdelivery.com/compings_v2/pavelstasevich/pavelstasevich1811/pavelstasevich181101028.jpg");
                }
            }
            else
            {
                indiceImg --;
            }
        }

        //VOLVER IMAGEN
        private void btnImagenAnterior_Click(object sender, EventArgs e)
        {
            indiceImg--;

            if (indiceImg > -1)
            {
                try
                {
                    pbImagen.Load(articulo.ImagenArt[indiceImg].URLImagen);
                }
                catch(Exception)
                {
                    pbImagen.Load("https://images.assetsdelivery.com/compings_v2/pavelstasevich/pavelstasevich1811/pavelstasevich181101028.jpg");
                }
            }
            else
            {
                indiceImg ++;
            }
        }
    }
}
