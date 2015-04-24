using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppJuego.Modelo
{
    public class Artificiales : Personajes, IFicha
    {
        #region Atributos

        private string planetaOrigen;
        private string forma;

        #endregion

        #region Propiedades
        public string PlanetaOrigen
        {
            get { return planetaOrigen; }
            set { planetaOrigen = value; }
        }
        public string Forma
        {
            get { return forma; }
            set { forma = value; }
        }
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor por defecto de Artificiales.
        /// </summary>
        public Artificiales() : base()
        
        {
            this.forma = "";
        }
        /// <summary>
        /// Contructor de inicialización de un Artificiales
        /// </summary>
        /// <param name="nombre">Nombre del SuperHumano</param>
        /// <param name="genero">Genero del SuperHumano</param>
        /// <param name="planetaOrigen">Planeta de Origen del Artificiales</param>
        public Artificiales(string nombre, string genero, double estatura, double peso, string forma, string planetaOrigen)
            : base(nombre, genero, estatura, peso)
        {
            this.forma = forma;
            this.planetaOrigen = planetaOrigen;
        }
        
        #endregion

        #region Metodos Sobreescritos
       
        public override string ToString()
        {
            return base.ToString() + "Planeta de Origen: " + planetaOrigen + "forma "+ forma+"\n\n" + Caracteristicas + "\n" + Enemigos;
        }
        ///<summary>
        ///Retorna verdadero si los objetos comparados son iguales, falso para contario
        ///</summary>
        ///<return> Retorna verdadero o falso </return>
        public override bool Equals(object obj)
        {
            Artificiales sh = (Artificiales)obj;
            bool result = false;

            if (base.Equals(sh) && (this.forma == sh.forma) &&( this.planetaOrigen == sh.planetaOrigen))
                result = true;

            return result;
        }
        ///<summary>
        ///Retorna Codigo Has del objeto
        ///</summary>
        ///<return> Retorna hasCode del objeto</return>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

        #region Metodo Abstrabto sobreescrito
        /// <summary>
        /// Metodo Abstrabto del personaje para saber que clase es...
        /// </summary>
        public override string tipoPersonaje(){
            return "Artificiales";
        }

        #endregion

        #region Implementacion de la Interfaz

        List<Caracterizacion> caracteristicas = new List<Caracterizacion>();
        List<Personajes> enemigos = new List<Personajes>();

        public string Enemigos
        {
            get
            {
                string salida = "Enemigos: \n";
                foreach (Personajes value in enemigos)
                    salida += value.Nombre + "\n";

                return salida;
            }
        }

        public string Caracteristicas
        {
            get
            {
                string salida = "Caracterizacion: \n";
                foreach (Caracterizacion value in caracteristicas)
                    salida += value.descripcion() + "\n";

                return salida;
            }

        }

        //Metodos de la Interfaz
        /// <summary>
        /// Añade una caracteristica al Personaje
        /// </summary>
        /// <param name="caracterizacion">Una Caracterizacion</param>
        public void add(Caracterizacion caracterizacion)
        {
            this.caracteristicas.Add(caracterizacion);


        }
        /// <summary>
        /// Establece la Liga del Personaje
        /// </summary>
        /// <param name="liga">Liga del Personaje</param>
        public void liga(string liga)
        {
            System.Console.WriteLine("Pertenezco a la Liga: " + liga);
        }
        /// <summary>
        /// Establece o Añade un o Varios enemigos del Personaje
        /// </summary>
        /// <param name="enemigo">Enemigos del Personaje</param>
        public void enemigo(Personajes enemigo)
        {
            this.enemigos.Add(enemigo);
        }

        #endregion 
    }
}
