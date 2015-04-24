using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppJuego.Modelo
{
    public abstract class Personajes
    {
        #region Atributos
        private long id;
        private string nombre;
        private char genero;
        private double estatura;
        private double peso;
        private List<Caracterizacion> caracteristicas = new List<Caracterizacion>();
        private List<Armas> armas = new List<Armas>();
        private string genero1;
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene o Estable el Nombre del Personaje
        /// </summary>

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        /// <summary>
        /// Obtiene o Establece el Genero del Personaje 'M' o 'F'
        /// </summary>
        public char Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public double Estatura
        {
            get { return estatura; }
            set { estatura = value; }
        }
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public List<Caracterizacion> Caracteristicas
        {
            get { return caracteristicas; }
            set { caracteristicas = value; }
        }

        public List<Armas> Armas
        {
            get { return armas; }
            set { armas = value; }
        }

        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto de Personaje.
        /// </summary>
        public Personajes()
        {
            id = 0;
            nombre = "Personaje Name";
            genero = 'M';
            estatura = 0.0;
            peso = 0.0;

        }
        /// <summary>
        /// Contructor de inicialización de Personaje
        /// </summary>
        /// <param name="nombre">Nombre del Personaje</param>
        /// <param name="genero">Genero del Personaje</param>
        public Personajes(string nombre, char genero, double estatura, double peso)
        {
            this.nombre = nombre;
            this.genero = genero;
            this.estatura = estatura;
            this.peso = peso;
        }

        public Personajes(string nombre, string genero1, double estatura, double peso)
        {
            // TODO: Complete member initialization
            this.nombre = nombre;
            this.genero1 = genero1;
            this.estatura = estatura;
            this.peso = peso;
        }

        #endregion

        #region Metodos Sobrescritos de Object

        /// <summary>
        /// Retorna la descripición del Personaje
        /// </summary>
        /// <returns>Retorna la descripición del Personaje</returns>
        public override string ToString()
        {
            string texto = "";
            foreach (Caracterizacion c in caracteristicas)
            {
                texto += c.ToString();
            }
            texto += "\n";
            foreach (Armas a in Armas)
            {
                texto += a.ToString();
            }
            return "Identificacion:" + this.id + "\n" +
                   "Nombre: " + this.nombre + "\n" +
                   "Genero: " + this.genero + "\n"+
                   "\nEstatura: " + this.estatura +
                   "\nPeso: " + this.peso + texto;
    
        }
        ///<summary>
        ///Retorna verdadero si los objetos comparados son iguales, falso para contario
        ///</summary>
        ///<return> Retorna verdadero o falso </return>
        public override bool Equals(object obj)
        {
            Personajes p = (Personajes)obj;
            bool result = false;

            if ((this.nombre == p.nombre)&&
                 (this.genero == p.genero) &&
                (this.estatura== p.estatura) &&
                (this.peso == p.peso))
                    result = true;
            
            return result;
        }
        #endregion

        #region "Métodos"
        public virtual string tipoPersonaje()
        {
            return "Personaje";
        }

        public bool tieneCaracteristica(string nombre)
        {
            foreach (Caracterizacion c in caracteristicas)
            {
                if (c.Nombre == nombre) return true;
            }
            return false;
        }

        public void nuevaCaracteristica(string nombre, string tipo)
        {
            if (!tieneCaracteristica(nombre))
            {
                caracteristicas.Add(new Caracterizacion(nombre, tipo));
                RepositorioCaracterizacion r = new RepositorioCaracterizacion();
                r.addCaracteristica(new Caracterizacion(nombre, tipo));
            }
        }

        public IEnumerable<Caracterizacion> getCaracteristicas()
        {
            return caracteristicas;
        }

        public IEnumerable<String> getNombresCaracteristicas()
        {
            List<string> nombres = new List<string>();
            foreach (Caracterizacion c in caracteristicas)
            {
                String n = c.Nombre;
                nombres.Add(n);
            }
            return nombres;
        }

        #endregion
    }
}