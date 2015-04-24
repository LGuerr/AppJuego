using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppJuego.Modelo
{
    public class Alíens: Personajes, IFicha
    {
        #region Atributos

        private string planetaOrigen;
        private string raza;

        #endregion

        #region Propiedades
        public string PlanetaOrigen
        {
            get { return planetaOrigen; }
            set { planetaOrigen = value; }
        }
        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }
        #endregion

        #region Constructores

        
        public Alíens() : base() 
        {
            this.raza = "";
            this.planetaOrigen = "";
        }
        
        public Alíens(string nombre, string genero, double estatura, double peso, string raza, string planetaOrigen) :
            base(nombre, genero, estatura, peso)

        {
            this.raza = raza;
            this.planetaOrigen = planetaOrigen;
        }
        
        #endregion

        #region Metodos Sobreescritos
        /// <summary>
        /// Retorna la descripición del Alíens
        /// </summary>
        /// <returns>Retorna la descripición del Alíens</returns>
        public override string ToString()
        {
            return base.ToString() + "Planeta de Origen: " + planetaOrigen + "\nRaza: " + raza + "\n\n" + Caracteristicas + "\n" + Enemigos;
        }
        ///<summary>
        ///Retorna verdadero si los objetos comparados son iguales, falso para contario
        ///</summary>
        ///<return> Retorna verdadero o falso </return>
        public override bool Equals(object obj)
        {
            Alíens sh = (Alíens)obj;
            bool result = false;

            if (base.Equals(sh) && (this.planetaOrigen == sh.planetaOrigen)&&(this.raza == sh.raza))
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
        public override string TipoPersonaje(){
            return "Aliens";

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
