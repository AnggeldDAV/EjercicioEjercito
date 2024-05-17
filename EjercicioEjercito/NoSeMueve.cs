using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito
{
    public class NoSeMueve : IMovimiento
    {
        public double Velocidad { get; set; } = 0;
    }
}
