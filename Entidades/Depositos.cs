using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Depositos
    {
        [Key]
        public int DepositoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre_Cuenta { get; set; }
        public string Concepto { get; set; }
        public decimal Monto { get; set; }

        public Depositos()
        {

        }
        public Depositos(int depositoId, DateTime fecha, string nombre_cuenta, string concepto, decimal monto)
        {
            this.DepositoId = depositoId;
            this.Fecha = fecha;
            this.Nombre_Cuenta = nombre_cuenta;
            this.Concepto = concepto;
            this.Monto = monto;
        }
    }
}
