using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualRace
{
    public class Auto
    {
        private eFabricante _fabricante;
        private string _nombrePiloto;
        public Rueda DI;
        public Rueda DD;
        public Rueda TI;
        public Rueda TT;
        private Kilometros kilometrosRecorridos;
        private Tiempo tiempoDemorado;

        public static int contadorDeObjetos;
        private static Random randomMarcas;

        public Auto() //Constructor de instancia
        {
            this._fabricante = (eFabricante)randomMarcas.Next(1, 3);
            this.DI = new Rueda();
            this.DD = new Rueda();
            this.TI = new Rueda();
            this.TT = new Rueda();
            kilometrosRecorridos = 0;
            tiempoDemorado = 0;
            Auto.contadorDeObjetos++;
        }

        public Auto(string piloto, eFabricante fabricante)
            : this()
        {
            this._fabricante = fabricante;
            this._nombrePiloto = piloto;
        }

        public static bool CompararAuto(Auto primero, Auto segundo)
        {
            if (primero._fabricante == segundo._fabricante)
                return true;
            return false;
        }

        static Auto() //Constructor estàtico, este se ejecuta una sola vez
        {
            Auto.contadorDeObjetos = 0;
            Auto.randomMarcas = new Random();
        }

        public string MostrarAuto()
        {
            return returnString();
        }

        public string returnString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("El fabricante es: " + this._fabricante);
            sb.AppendLine("Kilometros recorridos: " + (int)this.kilometrosRecorridos);
            sb.AppendLine("Tiempo demorado: " + (int)this.tiempoDemorado);

            return sb.ToString();
        }

        private string returnStringParaListado()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("F: " + this._fabricante + " - ");
            sb.AppendLine("P: " + this._nombrePiloto);

            return sb.ToString();
        }

        public void agregar(Tiempo time)
        {
            this.tiempoDemorado = this.tiempoDemorado + time;
        }

        public void agregar(Kilometros km)
        {
            this.kilometrosRecorridos = this.kilometrosRecorridos + km;
        }

        public void volverAZero()
        {
            this.kilometrosRecorridos = 0;
            this.tiempoDemorado = 0;
        }

        public Kilometros ObtenerKilometros()
        {
            return this.kilometrosRecorridos;
        }
        public Tiempo ObtenerTiempo()
        {
            return this.tiempoDemorado;
        }

        //Propiedad del tipo get
        /*Ejemplo:
         * private string _nombrePiloto;
         * public string NombrePiloto
         * {
         *      set
         *      {
         *          this._nombrePiloto = value;
         *      }
         *      get
         *      {
         *          return this._nombrePiloto;
         *      }
         * }*/
        public string DatosEnString
        {
            get
            {
                return this.returnStringParaListado();
            }
        }

        public eFabricante Fabricante
        {
            get
            {
                return this._fabricante;
            }
        }

        public string NombrePiloto
        {
            get
            {
                return this._nombrePiloto;
            }
        }
    }
}
