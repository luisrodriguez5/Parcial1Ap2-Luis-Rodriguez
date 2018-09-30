using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DepositosBLL
    {
        public static bool Guardar(Depositos depositos)
        {
            using (var context = new Respository<Depositos>())
            {
                try
                {
                    if (Buscar(p => p.DepositoId == depositos.DepositoId) == null)
                    {
                        return context.Guardar(depositos);
                    }
                    else
                    {
                        return context.Modificar(depositos);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static Depositos Buscar(Expression<Func<Depositos, bool>> criterio)
        {
            using (var context = new Respository<Depositos>())
            {
                try
                {
                    return context.Buscar(criterio);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static bool Eliminar(Depositos depositos)
        {
            using (var context = new Respository<Depositos>())
            {
                try
                {
                    return context.Eliminar(depositos);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static List<Depositos> GetListAll()
        {
            using (var context = new Respository<Depositos>())
            {
                try
                {
                    return context.GetListAll();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static List<Depositos> GetList(Expression<Func<Depositos, bool>> criterio)
        {
            using (var context = new Respository<Depositos>())
            {
                try
                {
                    return context.GetList(criterio);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
