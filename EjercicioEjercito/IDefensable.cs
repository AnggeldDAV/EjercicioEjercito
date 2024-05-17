using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito
{
    public interface IDefensable
    {
        public double Velocidad {  get; set; } 
        public double Blindaje { get; set; }
        public double PotenciaFuego { get; set; }
        public decimal Precio { get; set; }
        public double CapacidadMilitar();
    }
}
