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
                    /*foreach (Imagen x in listaImg)
                    {
                        if(x.IdArt == aux.ID)
                        {
                            //IMAGENART ES UNA LISTA DE IMAGENES EN ARTICULOS
                            aux.ImagenArt.Add(x);
                        }
                    }*/
                    aux.ImagenArt = ObtenerImagenes(aux);

                    //articulos.Add(aux);
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

        public List<Imagen> ObtenerImagenes(Articulo articulo)
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            List<Imagen> listaImagenes = new List<Imagen>();
            List<Imagen> aux = new List<Imagen>();

            aux = imagenNegocio.ObtenerDatos();


            foreach (Imagen x in aux)
            {
                if (x.IdArt == articulo.ID)
                {
                    //IMAGENART ES UNA LISTA DE IMAGENES EN ARTICULOS
                    listaImagenes.Add(x);
                }
            }

            return listaImagenes;
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

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datosArt = new AccesoDatos();

            try
            {
                string consulta = "SELECT A.Nombre Nombre, M.Descripcion Marca, C.Descripcion Categoria, Precio FROM ARTICULOS A INNER JOIN MARCAS M ON M.Id = A.IdMarca INNER JOIN CATEGORIAS C ON C.Id = A.IdCategoria WHERE ";

                switch (campo)
                {
                    case "Nombre":
                        consulta += "A.Nombre LIKE ";

                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "'" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "'%" + filtro + "'";
                                break;
                            case "Contiene":
                                consulta += "'%" + filtro + "%'";
                                break;
                        }
                        break;
                    case "Marca":
                        consulta += "M.Descripcion LIKE ";
                        
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "'" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "'%" + filtro + "'"; 
                                break;
                            case "Contiene":
                                consulta += "'%" + filtro + "%'";
                                break;
                        }
                        break;
                    case "Categoria":
                        consulta += "C.Descripcion LIKE ";
                        
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "'" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "'%" + filtro + "'";
                                break;
                            case "Contiene":
                                consulta += "'%" + filtro + "%'";
                                break;
                        }
                        break;
                    case "Precio":
                        consulta += "Precio ";
                        
                        switch (criterio)
                        {
                            case "Mayor a":
                                consulta += "> " + filtro;
                                break;
                            case "Menor a":
                                consulta += "< " + filtro;
                                break;
                            case "Igual a":
                                consulta += "= " + filtro;
                                break;
                            default:
                                break;
                        }
                        break;
                    
                }

                datosArt.SetearConsulta(consulta);
                datosArt.AbrirConexionEjecutarConsulta();

                while (datosArt.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    //aux.ID = (int)datosArt.Lector["Id"];
                    aux.NombreArt = (string)datosArt.Lector["Nombre"];
                    aux.MarcaArt.NombreMarca = (string)datosArt.Lector["Marca"];
                    aux.CategoriaArt.NombreCategoria = (string)datosArt.Lector["Categoria"];
                    aux.PrecioArt = (decimal)datosArt.Lector["Precio"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
