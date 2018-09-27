using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuentas
    {
        public int CuentaId { get; set; }
        public DateTime Fecha  { get; set; }
        public string Nombre { get; set; }
        public decimal Balance { get; set; }

        public Cuentas()
        {

        }
        public Cuentas(int cuentaId, DateTime fecha, string nombre, decimal balance )
        {
            this.CuentaId = cuentaId;
            this.Fecha = fecha;
            this.Nombre = nombre;
            this.Balance = balance;


        }
    }
}
