using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito
{
    public class Vehiculos : IDefensable
    {
        public double Velocidad { get; set; }
        public double Blindaje { get; set; }
        public double PotenciaFuego { get; set; }
        public decimal Precio { get; set; }

        public double CapacidadMilitar()
        {
            return ((this.PotenciaFuego * this.Velocidad) / 2) / (100 - this.Blindaje);
        }
        public override string ToString()
        {
            return $"Vehiculo velocidad {Velocidad}, blindaje: {Blindaje}, potencia de fuego {PotenciaFuego}, precio {Precio} y capacidad militar: {CapacidadMilitar()}";
        }
    }
}

