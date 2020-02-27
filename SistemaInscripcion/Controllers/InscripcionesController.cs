using Microsoft.EntityFrameworkCore;
using SistemaInscripcion.Data;
using SistemaInscripcion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaInscripcion.Controllers
{
    public static class InscripcionesController
    {
        public static bool Guardar(Inscripciones entity)
        {
            Contexto db = new Contexto();
            bool paso = false;
            try
            {
                if (db.Inscripciones.Any(A => A.InscripcionId == entity.InscripcionId))
                {
                    paso = Modificar(entity);
                }
                else
                {
                    paso = Insertar(entity);
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
        private static bool Insertar(Inscripciones entity)
        {
            Contexto db = new Contexto();
            bool paso = false;
            try
            {
                db.Inscripciones.Add(entity);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
        private static bool Modificar(Inscripciones entity)
        {
            Contexto db = new Contexto();
            bool paso = false;
            try
            {
                db.Entry(entity).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
        public static bool Eliminar(int Id)
        {
            Contexto db = new Contexto();
            bool paso = false;
            try
            {
                Inscripciones Inscripcion = db.Inscripciones.Find(Id);
                if (Inscripcion != null)
                {
                    db.Entry(Inscripcion).State = EntityState.Deleted;
                    paso = db.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
        public static Inscripciones Buscar(int Id)
        {
            Contexto db = new Contexto();
            Inscripciones Inscripcion;
            try
            {
                Inscripcion = db.Inscripciones.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Inscripcion;
        }
        public static List<Inscripciones> GetList(Expression<Func<Inscripciones, bool>> expression)
        {
            List<Inscripciones> lista = new List<Inscripciones>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Inscripciones.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return lista;
        }
    }
}
