using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito
{
    internal class Fabrica01 : IFactory
    {
        public IDefensable Unidad(TiposMilitares tipo ,double Velocidad, double Blindaje, double PotenciaFuego, decimal Precio)
        {
            IDefensable unidades;
            switch (tipo)
            {
                case TiposMilitares.Caballeria: unidades = new Vehiculos() {Velocidad=Velocidad, Blindaje= Blindaje, PotenciaFuego = PotenciaFuego, Precio=Precio }; break;
                case TiposMilitares.Infateria: unidades = new Soldados() { Velocidad = Velocidad, Blindaje = Blindaje, PotenciaFuego = PotenciaFuego, Precio = Precio }; break;
                case TiposMilitares.Artilleria: unidades = new Canones() { Velocidad = Velocidad, Blindaje = Blindaje, PotenciaFuego = PotenciaFuego, Precio = Precio }; break;
                default: return null;
            }
            return unidades;
        }
    }
}
