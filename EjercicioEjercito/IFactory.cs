using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito
{
    public interface IFactory
    {
        public IDefensable Unidad(TiposMilitares tipo ,double Velocidad, double Blindaje, double PotenciaFuego, decimal Precio);
    }
}
