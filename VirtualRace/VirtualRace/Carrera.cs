using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualRace
{
    public class Carrera
    {
        //DEPRECATED: Por colecciones
        /*public Auto auto1;
        public Auto auto2;
        public Auto auto3;
        public Auto auto4;
        public Auto auto5;
        public Auto auto6;*/

        public List<Auto> listaDeAutos;

        private static Random randomKilometros;
        private static Random randomTiempo;
        private string _nombre;
        private string _fecha;
        private string _lugar;

        #region Constructores

        public Carrera()
        {
            this.listaDeAutos = new List<Auto>();

            /*this.auto1 = new Auto();
            this.auto2 = new Auto();
            this.auto3 = new Auto();
            this.auto4 = new Auto();
            this.auto5 = new Auto();
            this.auto6 = new Auto();*/
            //Depreticate por colecciones
        }

        public Carrera(string nombre, string lugar, string fecha)
        {
            this._nombre = nombre;
            this._lugar = lugar;
            this._fecha = fecha;

            this.listaDeAutos = new List<Auto>();
        }

        static Carrera()
        {
            randomKilometros = new Random();
            randomTiempo = new Random();
        }

        #endregion

        private bool agregarAuto(Auto unAuto)
        {
            this.listaDeAutos.Add(unAuto);
            return true;
        }

        public static Carrera operator +(Carrera carrera, Auto unAuto)
        {
            carrera.agregarAuto(unAuto);

            return carrera;
        }

        public string correrCarrera(Tiempo tiempo)
        {


            int contadorMinutos;
            Auto mayor = new Auto();
            Auto menor = new Auto();

            for (contadorMinutos = 0; contadorMinutos < (int)tiempo; contadorMinutos++)
            {
                /* DEPRETICATED por colecciones
                     this.auto1.Agregar((Tiempo)numeroRandom.Next(10, 100));
                     this.auto2.Agregar((Tiempo)numeroRandom.Next(10, 100));
                     this.auto3.Agregar((Tiempo)numeroRandom.Next(10, 100));
                     this.auto4.Agregar((Tiempo)numeroRandom.Next(10, 100));
                     this.auto5.Agregar((Tiempo)numeroRandom.Next(10, 100));
                     this.auto6.Agregar((Tiempo)numeroRandom.Next(10, 100));
                        */
                foreach (Auto item in this.listaDeAutos)
                {

                    item.agregar((Tiempo)randomTiempo.Next(10, 100));
                }


            }

            for (int elemento = 0; elemento < this.listaDeAutos.Count; elemento++)
            {
                if (elemento == 0)
                {
                    menor = this.listaDeAutos[elemento];
                    mayor = this.listaDeAutos[elemento];
                    continue;
                }
                if ((int)this.listaDeAutos[elemento].ObtenerTiempo() < (int)menor.ObtenerTiempo())
                    menor = this.listaDeAutos[elemento];

                if ((int)this.listaDeAutos[elemento].ObtenerTiempo() > (int)mayor.ObtenerTiempo())
                    mayor = this.listaDeAutos[elemento];


            }

            

            Console.WriteLine("El que más recorrió fue un {0} y la distancia fue {1}", mayor.Fabricante, (int)mayor.ObtenerTiempo());
            Console.WriteLine("El que menos recorri´0 fue un {0} y la distancia fue {1}", menor.Fabricante, (int)menor.ObtenerTiempo());

            

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Auto con menor tiempo: " + menor.Fabricante);
            sb.AppendLine("Piloto: " + menor.NombrePiloto);
            sb.AppendLine("Tiempo demorado: " + (int)menor.ObtenerTiempo());
            sb.AppendLine("");
            sb.AppendLine("Auto con mayor tiempo: " + mayor.Fabricante);
            sb.AppendLine("Piloto: " + mayor.NombrePiloto);
            sb.AppendLine("Tiempo demorado: " + (int)mayor.ObtenerTiempo());

            foreach (Auto item in this.listaDeAutos)
            {
                item.volverAZero();
            }

            return sb.ToString();
        }

       

        /*public void correrCarrera(Tiempo time)
        {
            int contador;
            
            for (contador = 0; contador < (int)time; contador++)
            {
                foreach (Auto unAuto in this.listaDeAutos)
                {
                    unAuto.agregar((Tiempo)randomTiempo.Next(10,100));
                }

                //DEPRECATED: Por colecciones
                this.auto1.agregar(timeAux = randomTiempo.Next(10, 100));
                this.auto2.agregar(timeAux = randomTiempo.Next(10, 100));
                this.auto3.agregar(timeAux = randomTiempo.Next(10, 100));
                this.auto4.agregar(timeAux = randomTiempo.Next(10, 100));
                this.auto5.agregar(timeAux = randomTiempo.Next(10, 100));
                this.auto6.agregar(timeAux = randomTiempo.Next(10, 100));
            }
        }*/

        /*public void correrCarrera(Kilometros km)
        {
            int contador;
            
            for (contador = 0; contador < (int)km; contador++)
            {
                foreach (Auto unAuto in this.listaDeAutos)
                {
                    unAuto.agregar((Kilometros)randomKilometros.Next(10, 100));
                }


                
                //DEPRECATED: Por colecciones
                /*this.auto1.agregar(auxKm = randomKilometros.Next(10, 100));
                this.auto2.agregar(auxKm = randomKilometros.Next(10, 100));
                this.auto3.agregar(auxKm = randomKilometros.Next(10, 100));
                this.auto4.agregar(auxKm = randomKilometros.Next(10, 100));
                this.auto5.agregar(auxKm = randomKilometros.Next(10, 100));
                this.auto6.agregar(auxKm = randomKilometros.Next(10, 100));
            }
        }*/

        public string correrCarrera(Kilometros km)
        {


            int contadorMinutos;
            Auto mayor = new Auto();
            Auto menor = new Auto();

            for (contadorMinutos = 0; contadorMinutos < (int)km; contadorMinutos++)
            {
                /* DEPRETICATED por colecciones
                     this.auto1.Agregar((Tiempo)numeroRandom.Next(10, 100));
                     this.auto2.Agregar((Tiempo)numeroRandom.Next(10, 100));
                     this.auto3.Agregar((Tiempo)numeroRandom.Next(10, 100));
                     this.auto4.Agregar((Tiempo)numeroRandom.Next(10, 100));
                     this.auto5.Agregar((Tiempo)numeroRandom.Next(10, 100));
                     this.auto6.Agregar((Tiempo)numeroRandom.Next(10, 100));
                        */
                foreach (Auto item in this.listaDeAutos)
                {

                    item.agregar((Kilometros)randomKilometros.Next(10, 100));
                }


            }

            for (int elemento = 0; elemento < this.listaDeAutos.Count; elemento++)
            {
                if (elemento == 0)
                {
                    menor = this.listaDeAutos[elemento];
                    mayor = this.listaDeAutos[elemento];
                    continue;
                }
                if ((int)this.listaDeAutos[elemento].ObtenerKilometros() < (int)menor.ObtenerKilometros())
                    menor = this.listaDeAutos[elemento];

                if ((int)this.listaDeAutos[elemento].ObtenerKilometros() > (int)mayor.ObtenerKilometros())
                    mayor = this.listaDeAutos[elemento];


            }

            /*DEPRETICATED por colecciones
            menor = mayor = auto1;
            if ((int)this.auto2.ObtenerKilometros() < (int)menor.ObtenerKilometros())
                menor = auto2;
            if ((int)this.auto2.ObtenerKilometros() > (int)mayor.ObtenerKilometros())
                mayor = auto2;
            if ((int)this.auto3.ObtenerKilometros() < menor.ObtenerKilometros())
                menor = auto3;
            if ((int)this.auto3.ObtenerKilometros() > (int)mayor.ObtenerKilometros())
                mayor = auto3;
            if ((int)this.auto4.ObtenerKilometros() < menor.ObtenerKilometros())
                menor = auto4;
            if ((int)this.auto4.ObtenerKilometros() > (int)mayor.ObtenerKilometros())
                mayor = auto4;
            if ((int)this.auto5.ObtenerKilometros() < menor.ObtenerKilometros())
                menor = auto5;
            if ((int)this.auto5.ObtenerKilometros() > (int)mayor.ObtenerKilometros())
                mayor = auto5;
            if ((int)this.auto6.ObtenerKilometros() < menor.ObtenerKilometros())
                menor = auto6;
            if ((int)this.auto6.ObtenerKilometros() > (int)mayor.ObtenerKilometros())
                mayor = auto6;
             * */

            /*Console.WriteLine("El que más recorrió fue un {0} y la distancia fue {1}", mayor.Fabricante, (int)mayor.ObtenerKilometros());
            Console.WriteLine("El que menos recorri´0 fue un {0} y la distancia fue {1}", menor.Fabricante, (int)menor.ObtenerKilometros());*/




            /* DEPRETICATED por colecciones
               this.auto1.VolverACero();
               this.auto2.VolverACero();
               this.auto3.VolverACero();
               this.auto4.VolverACero();
               this.auto5.VolverACero();
               this.auto6.VolverACero();
                */
            

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Auto con mayor kilometros: " + mayor.Fabricante);
            sb.AppendLine("Piloto: " + mayor.NombrePiloto);
            sb.AppendLine("Kilometros recorridos: " + (int)mayor.ObtenerKilometros());
            sb.AppendLine("");
            sb.AppendLine("Auto con menor kilometros: " + menor.Fabricante);
            sb.AppendLine("Piloto: " + menor.NombrePiloto);
            sb.AppendLine("Kilometros recorridos: " + (int)menor.ObtenerKilometros());

            foreach (Auto item in this.listaDeAutos)
            {
                item.volverAZero();
            }

            return sb.ToString();
        }

        public string MostrarCarrera()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Carrera");

            foreach (Auto unAuto in this.listaDeAutos)
            {
                sb.AppendLine(unAuto.returnString());
            }

            //DEPRICATED: Por colecciones
            /*this.auto1.MostrarAuto();
            this.auto2.MostrarAuto();
            this.auto3.MostrarAuto();
            this.auto4.MostrarAuto();
            this.auto5.MostrarAuto();
            this.auto6.MostrarAuto();*/

            return sb.ToString();
        }
    }
}
