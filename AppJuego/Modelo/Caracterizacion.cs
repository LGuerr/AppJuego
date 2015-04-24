using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppJuego
{
    public  class Caracterizacion
    {
        #region Atributos
        private string nombre;
        private string tipo;
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene o Estable el Nombre de caractcerizacion.
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        /// <summary>
        /// Obtiene o Estable el Tipo de Caracterizacion.
        /// </summary>
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto de una Caracterizacion.
        /// </summary>
        public Caracterizacion()
        {

            nombre = "Mi Nombre de Caracterizacion";
            tipo = "Mi Tipo de Caracterizacion";
        }
        /// <summary>
        /// Constructor de Inicializacion de una Caracterizacion
        /// </summary>
        /// <param name="nombre">Nombre de la Caracterizacion</param>
        /// <param name="tipo">Tipo de Caracterizacion</param>
        public Caracterizacion(string nombre, string tipo)
        {

            this.nombre = nombre;
            this.tipo = tipo;
        }

        #endregion

        #region Metodos Override base
        /// <summary>
        /// Retorna la descripición de la Caracterizacion
        /// </summary>
        /// <returns>Retorna un string con la descripición de la Caracterizacion</returns>
        public override string ToString()
        {
            return "Nombre : " + this.nombre + "\n"
                   + "Tipo : " + this.tipo + "\n";
        }
        ///<summary>
        ///Retorna verdadero si los objetos comparados son iguales, falso para contario
        ///</summary>
        ///<return> Retorna verdadero o falso </return>
        public override bool Equals(object obj)
        {

            Caracterizacion c = (Caracterizacion)obj;

            bool resul = false;

            if ((this.nombre == c.nombre) && (this.tipo == c.tipo))
                resul = true;

            return resul;
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

        #region Metodos abstractos
        /// <summary>
        /// Metodo Abstrabto que describe la caracteristica.
        /// </summary>
        /// <returns>returna un string con la descripcion de la caracteristica</returns>
        public abstract string descripcion();

        #endregion

    }
}