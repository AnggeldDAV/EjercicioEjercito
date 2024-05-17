using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito
{
    
    public class Ejercito : IColeccionable, IDefensable
    {
        public double TotalBlindaje { get; set; }
        public double TotalCapacidadMilitar { get; set; }
        public double TotalPotenciaFuego { get; set; }
        public double TotalVelocidad {  get; set; } 
        public decimal TotalGasto { get; set; }
        public int TotalElementos { get; set; } = 0;
        public List<IDefensable> ElementosEjercito { get; set; } = new();
        public double Velocidad { get { return VelocidadTotal(); } set { } }
        public double Blindaje { get { return BlindajeTotal(); } set { } }
        public double PotenciaFuego { get { return PotenciaFuegoTotal(); } set { } }
        public decimal Precio { get { return GastoTotal(); } set { } }

        public void Add(IDefensable elemento)
        {
            this.ElementosEjercito.Add(elemento);
            this.TotalElementos++;
        }

        public double BlindajeTotal()
        {
            TotalBlindaje = 0;
            foreach(IDefensable obj in ElementosEjercito)
            {
                TotalBlindaje += obj.Blindaje;
            }
            return TotalBlindaje;
        }

        public double CapacidadMilitarTotal()
        {
            TotalCapacidadMilitar = 0;
            foreach (IDefensable obj in ElementosEjercito)
            {
                TotalCapacidadMilitar += obj.CapacidadMilitar();
            }
            return TotalCapacidadMilitar;
        }
        public double PotenciaFuegoTotal()
        {
            TotalPotenciaFuego = 0;
            foreach (IDefensable obj in ElementosEjercito)
            {
                TotalPotenciaFuego += obj.PotenciaFuego;
            }
            return TotalPotenciaFuego;
        }

        public decimal GastoTotal()
        {
            TotalGasto = 0;
            foreach (IDefensable obj in ElementosEjercito)
            {
                TotalGasto += obj.Precio;
            }
            return TotalGasto;
        }

        public double VelocidadTotal()
        {
            TotalVelocidad = 0;
            foreach (IDefensable obj in ElementosEjercito)
            {
                TotalVelocidad += obj.Velocidad;
            }
            return TotalVelocidad;
        }

        public double CapacidadMilitar()
        {
            return ((this.PotenciaFuego * this.Velocidad) / 2) / (100 - this.Blindaje);
        }
    }
}
