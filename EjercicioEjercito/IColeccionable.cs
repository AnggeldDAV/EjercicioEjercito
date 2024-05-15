using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito
{
    public interface IColeccionable
    {
        public int TotalElementos { get; set; }
        public void Add(IDefensable elemento);
        public double PotenciaFuegoTotal();
        public double BlindajeTotal();
        public double VelocidadTotal();
        public decimal GastoTotal();
        public double CapacidadMilitarTotal();
    }
}
