using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito
{
    public class Menu : IMenu
    {
        public IFactory Fabrica = new Fabrica01();
        public IColeccionable Ejer = new Ejercito();
        public IColeccionable ConjEjer = new Ejercito();
        public IDefensable Elemento;
        public string Tipo;
        public double Velocidad;
        public double Blindaje;
        public double PotenciaFuego;
        public decimal Precio;
        public void DameMensajes()
        {
            Console.WriteLine("Pulsa 1 Si quieres agregar un nuevo elemento \n" +
                "Pulsa 2 Si quieres listar todos los elementos \n" +
                "Pulsa 3 Si quieres crear un peloton (Conjunto de ejercitos)\n" +
                "Pulsa 4 Si quieres listar los atributos de los ejercitos\n \n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Si Pulsas otro numero o tecla se cerrara el programa");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public string EligeTipo()
        {
            Console.WriteLine("Elige uno de estos tipos: Caballeria, Infanteria o Artilleria ");
            Tipo = Console.ReadLine().ToLower();
            if (Tipo == "caballeria" | Tipo == "infanteria" | Tipo == "artilleria")
            {
                return Tipo;
            } else
            {
                EligeTipo();
                return null;
            }
        }
        public double EligeVelocidad()
        {
            Console.WriteLine("\nDime la velocidad: ");
            Velocidad = double.Parse(Console.ReadLine());
            return Velocidad;
        }
        public double EligeBlindaje()
        {
            Console.WriteLine("\nDime el blindaje: ");
            Blindaje = double.Parse(Console.ReadLine());
            return Blindaje;
        }
        public double EligePotenciaFuego()
        {
            Console.WriteLine("\nDime la potencia de fuego");
            PotenciaFuego = double.Parse(Console.ReadLine());
            return PotenciaFuego;
        }
        public decimal EligePrecio()
        {
            Console.WriteLine("\nDime su precio: ");
            Precio = decimal.Parse(Console.ReadLine());
            return Precio;
        }
        public void CreaElemento()
        {
            EligeTipo();
            try
            {
                EligeVelocidad();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDebe ser un numero");
                Console.ForegroundColor = ConsoleColor.White;
                EligeVelocidad();
            }
            try
            {
                EligeBlindaje();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDebe ser un numero");
                Console.ForegroundColor = ConsoleColor.White;
                EligeBlindaje();
            }
            try
            {
                EligePotenciaFuego();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDebe ser un numero");
                Console.ForegroundColor = ConsoleColor.White;
                EligePotenciaFuego();
            }
            try
            {
                EligePrecio();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDebe ser un numero");
                Console.ForegroundColor = ConsoleColor.White;
                EligePrecio();
            }
            switch (Tipo)
            {
                case "caballeria": Elemento = Fabrica.Unidad(TiposMilitares.Caballeria, Velocidad, Blindaje, PotenciaFuego, Precio); break;
                case "infanteria": Elemento = Fabrica.Unidad(TiposMilitares.Infateria, Velocidad, Blindaje, PotenciaFuego, Precio); break;
                case "artilleria": Elemento = Fabrica.Unidad(TiposMilitares.Artilleria, Velocidad, Blindaje, PotenciaFuego, Precio); break;
            }
            Ejer.Add(Elemento);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Elemento añadido: {Elemento}\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void ListaElementos()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Total elementos: {Ejer.TotalElementos}, Potencia de fuego total: {Ejer.PotenciaFuegoTotal()}, Blindaje total: {Ejer.BlindajeTotal()}, Capacidad de movimiento: {Ejer.VelocidadTotal()}, Gastos: {Ejer.GastoTotal()}, Capacidad Militar: {Ejer.CapacidadMilitarTotal()}\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void CreaPeloton()
        {
            ConjEjer.Add((IDefensable)Ejer);
        }
        public void ListaEjercito()
        {
            IDefensable Peloton = (IDefensable)ConjEjer;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Numero de ejercitos: {ConjEjer.TotalElementos}, Potencia de fuego total: {Peloton.PotenciaFuego}, Blindaje total: {Peloton.Blindaje}, Capacidad de movimiento: {Peloton.Velocidad}, Gastos: {Peloton.Precio}, Capacidad Militar: {Peloton.CapacidadMilitar()}\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void DameMenu()
        {
            int Opcion;
            DameMensajes();
            var validador = Int32.TryParse(Console.ReadLine(), out Opcion);
            if (validador)
            {
                while (Opcion == 1 | Opcion == 2 | Opcion == 3 | Opcion == 4)
                {
                    switch (Opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Elegiste la opcion 1\n");
                            CreaElemento();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Elegiste la opcion 2\n");
                            ListaElementos();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Elegiste la opcion 3");
                            CreaPeloton();
                            Console.WriteLine("Has creado un Peloton\n");
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Elegiste la opcion 4\n");
                            ListaEjercito();
                            break;
                    }
                    DameMensajes();
                    Int32.TryParse(Console.ReadLine(), out Opcion);
                }
                
                Console.WriteLine("Cerrando el programa");
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("La opcion debe ser un numero \n");
                Console.ForegroundColor = ConsoleColor.White;
                DameMenu();
            }
            
        }
    }
}
