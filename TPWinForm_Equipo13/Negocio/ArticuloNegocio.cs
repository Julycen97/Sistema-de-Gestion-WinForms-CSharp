using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public class ArticuloNegocio
    {
        //LISTA DE ARITUCLOS COMO ATRIBUTO PARA CARGAR GRILLA,
        private List<Articulo> articulos = new List<Articulo>();

        //OBTENER TODOS LOS DATOS
        public List<Articulo> ObtenerDatos()
        {
            //VARIABLE PARA OBTENCION DE REGISTROS DE ARTICULOS
            AccesoDatos datosArt = new AccesoDatos();
            //VARIABLE PARA OBTENCION DE TODAS LAS IMAGENES
            ImagenNegocio img = new ImagenNegocio();
            //LISTA PARA ALMACENAR TODAS LAS IMAGENES
            List<Imagen> listaImg = new List<Imagen>();

            try
            {
                //CARGA DE LISTA CON TODAS LAS IMAGENES
                listaImg = img.ObtenerDatos();

                datosArt.SetearConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion AS Marca, A.IdCategoria, C.Descripcion AS Categoria, Precio FROM ARTICULOS AS A, MARCAS AS M, CATEGORIAS AS C WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id");
                datosArt.AbrirConexionEjecutarConsulta();

                while (datosArt.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    
                    //NO SE CHEQUEA NULIDAD POR QUE NO ACEPTA VALORES NULOS
                    aux.ID = (int)datosArt.Lector["Id"];

                    //CHECK NULL
                    if (!(datosArt.Lector["Codigo"] is DBNull))
                    {
                        aux.CodArt = (string)datosArt.Lector["Codigo"];
                    }
                    //CHECK NULL
                    if (!(datosArt.Lector["Nombre"] is DBNull))
                    {
                        aux.NombreArt = (string)datosArt.Lector["Nombre"];
                    }
                    //CHECK NULL
                    if (!(datosArt.Lector["Descripcion"] is DBNull))
                    {
                        aux.DescripcionArt = (string)datosArt.Lector["Descripcion"];
                    }
                    //CHECK NULL
                    if (!(datosArt.Lector["IdMarca"] is DBNull))
                    {
                        aux.MarcaArt.IdMarca = (int)datosArt.Lector["IdMarca"];
                    }
                    //CHECK NULL
                    if (!(datosArt.Lector["Marca"] is DBNull))
                    {
                        aux.MarcaArt.NombreMarca = (string)datosArt.Lector["Marca"];
                    }
                    //CHECK NULL
                    if(!(datosArt.Lector["IdCategoria"] is DBNull))
                    {
                        aux.CategoriaArt.IdCategoria = (int)datosArt.Lector["IdCategoria"];
                    }
                    //CHECK NULL
                    if (!(datosArt.Lector["Categoria"] is DBNull))
                    {
                        aux.CategoriaArt.NombreCategoria = (string)datosArt.Lector["Categoria"];
                    }
                    //CHECK NULL
                    if (!(datosArt.Lector["Precio"] is DBNull))
                    {
                        aux.PrecioArt = (decimal)datosArt.Lector["Precio"];
                    }

                    //RECORRE TODAS LAS IMAGENES Y LAS AGREGA EN CASO DE COINCIDIR CON MISMO ID
                    foreach (Imagen x in listaImg)
                    {
                        if(x.IdArt == aux.ID)
                        {
                            //IMAGENART ES UNA LISTA DE IMAGENES EN ARTICULOS
                            aux.ImagenArt.Add(x);
                        }
                    }

                    articulos.Add(aux);
                }

                return articulos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datosArt.CerrarConexion();
            }
        }

        //AGREGAR O MODIFICAR DECIDIENDO POR BANDERA BOOLEANA
        //SETEANDO LA CONSULTA DEPENDIENDO EL CASO
        public void Agregar_ModificarDatos(Articulo aux, bool bandera)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                //SI ES TRUE AGREGA
                if(bandera)
                {
                    datos.SetearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");
                }
                //SI ES FALSE MODIFICA
                else
                {
                    datos.SetearConsulta("UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @Precio WHERE Id = @IdArt");
                    //SE COLOCA DENTRO DEL ELSE PORQUE FORMA PARTE DEL
                    //UPDATE EN EL WHERE
                    datos.SetearParametro("@IdArt", aux.ID);
                }

                datos.SetearParametro("@Codigo", aux.CodArt);
                datos.SetearParametro("@Nombre", aux.NombreArt);
                datos.SetearParametro("@Descripcion", aux.DescripcionArt);
                datos.SetearParametro("@IdMarca", aux.MarcaArt.IdMarca);
                datos.SetearParametro("@IdCategoria", aux.CategoriaArt.IdCategoria);
                datos.SetearParametro("@Precio", aux.PrecioArt);

                datos.AbrirConexionEjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    
        //ELIMINAR DATOS
        public void EliminarDatos(int IdArt)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("DELETE FROM ARTICULOS WHERE Id = @ID");
                datos.SetearParametro("@ID", IdArt);

                datos.AbrirConexionEjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
