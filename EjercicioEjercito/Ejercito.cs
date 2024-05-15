using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito
{
    
    public class Ejercito : IColeccionable
    {
        public double TotalBlindaje { get; set; } = 0;
        public double TotalCapacidadMilitar { get; set; } = 0;
        public double TotalPotenciaFuego { get; set; } = 0;
        public double TotalVelocidad {  get; set; } = 0;
        public decimal TotalGasto { get; set; } = 0;
        public int TotalElementos { get; set; } = 0;
        public List<IDefensable> ElementosEjercito { get; set; } = new();
        public void Add(IDefensable elemento)
        {
            this.ElementosEjercito.Add(elemento);
            this.TotalElementos++;
        }

        public double BlindajeTotal()
        {
            foreach(IDefensable obj in ElementosEjercito)
            {
                TotalBlindaje += obj.Blindaje;
            }
            return TotalBlindaje;
        }

        public double CapacidadMilitarTotal()
        {
            foreach (IDefensable obj in ElementosEjercito)
            {
                TotalCapacidadMilitar += obj.CapacidadMilitar();
            }
            return TotalCapacidadMilitar;
        }
        public double PotenciaFuegoTotal()
        {
            foreach (IDefensable obj in ElementosEjercito)
            {
                TotalPotenciaFuego += obj.PotenciaFuego;
            }
            return TotalPotenciaFuego;
        }

        public decimal GastoTotal()
        {
            foreach (IDefensable obj in ElementosEjercito)
            {
                TotalGasto += obj.Precio;
            }
            return TotalGasto;
        }

        public double VelocidadTotal()
        {
            foreach (IDefensable obj in ElementosEjercito)
            {
                TotalVelocidad += obj.Velocidad;
            }
            return TotalVelocidad;
        }
    }
}
