using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.DAL;
using ProyectoFinal.Entidades;
using System.Data.Entity;
using System.Linq.Expressions;


namespace ProyectoFinal.BLL
{
   public class CargoBLL
    {
        public static bool Guardar(Cargos cargo)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Cargo.Add(cargo) != null)
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



        public static Cargos Buscar(int id)
        {
            Contexto db = new Contexto();
            Cargos cargo = new Cargos();

            try
            {
                cargo = db.Cargo.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return cargo;
        }

        public static bool Modificar(Cargos cargo)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(cargo).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
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

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.Cargo.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);

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

        public static List<Cargos> GetList(Expression<Func<Cargos, bool>> cargo)
        {
            List<Cargos> Lista = new List<Cargos>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.Cargo.Where(cargo).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }

    }
}
