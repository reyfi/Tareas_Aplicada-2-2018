using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using RegistroCoArticulos.DAL;
using RegistroCoArticulos.Entidades;
using System.Data.Entity;

namespace RegistroCoArticulos.BLL
{
    class ArticulosBLL
    {
        public static bool Guardar(Articulos articulos)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if(contexto.Articulos.Add(articulos) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }

                contexto.Dispose();
            }
            catch(Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Editar(Articulos articulos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(articulos).State = EntityState.Modified;
                if(contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch(Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Articulos articulos = contexto.Articulos.Find(id);

                contexto.Articulos.Remove(articulos);

                if(contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch(Exception)
            {
                throw;
            }
            return paso;
        }

    }
}
