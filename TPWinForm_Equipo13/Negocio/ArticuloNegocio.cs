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
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion AS Marca, C.Descripcion AS Categoria, Precio FROM ARTICULOS AS A, MARCAS AS M, CATEGORIAS AS C WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id");
                datos.AbrirConexionEjecutarConsulta();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.ID = (int)datos.Lector["Id"];

                    //CHECK NULL
                    if (!(datos.Lector["Codigo"] is DBNull))
                    {
                        aux.CodArt = (string)datos.Lector["Codigo"];
                    }
                    //CHECK NULL
                    if (!(datos.Lector["Nombre"] is DBNull))
                    {
                        aux.NombreArt = (string)datos.Lector["Nombre"];
                    }
                    //CHECK NULL
                    if (!(datos.Lector["Descripcion"] is DBNull))
                    {
                        aux.DescripcionArt = (string)datos.Lector["Descripcion"];
                    }
                    //CHECK NULL
                    if (!(datos.Lector["Marca"] is DBNull))
                    {
                        aux.MarcaArt.NombreMarca = (string)datos.Lector["Marca"];
                    }
                    //CHECK NULL
                    if (!(datos.Lector["Categoria"] is DBNull))
                    {
                        aux.CategoriaArt.NombreCategoria = (string)datos.Lector["Categoria"];
                    }
                    //CHECK NULL
                    if (!(datos.Lector["Precio"] is DBNull))
                    {
                        aux.PrecioArt = (decimal)datos.Lector["Precio"];
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
                datos.CerrarConexion();
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
