using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;
using System.Data;

namespace CapaNegocio
{
   public class NCategoria
    {
        //Metodo Insertar que llama   al metodo insertar la clase DCategoria de mi capa datos 

        public static string Insertar(string nombre, string descripcion)
        {
            DCategoria Obj = new DCategoria();
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Insertar(Obj);
        }
        //Metodo Editar que llama   al metodo Editar la clase DCategoria de mi capa datos 

        public static string Editar(int Idcategoria, string nombre, string descripcion)
        {
            DCategoria Obj = new DCategoria();
            Obj.Idcategoria = Idcategoria;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Editar(Obj);
        }
        //Metodo Eliminar que llama   al metodo Eliminar la clase DCategoria de mi capa datos 

        public static string Eliminar(int Idcategoria)
        {
            DCategoria Obj = new DCategoria();
            Obj.Idcategoria = Idcategoria;
            return Obj.Eliminar(Obj);
        }
        //Metodo Mostrar que llama   al metodo Mostrar la clase DCategoria de mi capa datos 

        public static DataTable Mostrar()
        {

            return new DCategoria().Mostrar();
        }

        //BuscarNombre

        //Metodo BuscarNombre que llama   al metodo BuscarNombre la clase DCategoria de mi capa datos 

        public static DataTable BuscarNombre(string textobuscar)
        {
            DCategoria Obj = new DCategoria();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }


        //final del codigo -- capa Negocio
    }
}
