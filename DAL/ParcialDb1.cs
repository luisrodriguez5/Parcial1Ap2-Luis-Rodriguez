using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ParcialDb1 : DbContext
    {
        public ParcialDb1() : base("ConStr") 
        {

        }
        public DbSet<Cuentas> Cuentas { get; set; }
        public DbSet<Depositos> Depositos { get; set; }



    }
}
