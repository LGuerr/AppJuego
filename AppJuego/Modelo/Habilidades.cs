using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppJuego
{
    public class Habilidades : Caracterizacion
    {

        #region Constructores
        /// <summary>
        /// Constructor por defecto de Una Habilidad
        /// </summary>
        public Habilidades()
            : base() { }

        /// <summary>
        /// Constructor de Inicializacion de una Habilidad
        /// </summary>
        /// <param name="nombre">Nombre de la Habilidad</param>
        /// <param name="tipo">Tipo de Habilidad</param>
        public Habilidades(string nombre, string tipo)
            : base(nombre, tipo) { }

        #endregion

        #region Metodos override base
        /// <summary>
        /// Retorna la descripición de la Habilidad
        /// </summary>
        /// <returns>Retorna un string con la descripición de la Habilidad</returns>
        public override string ToString()
        {
            return base.ToString();
        }
        ///<summary>
        ///Retorna verdadero si los objetos comparados son iguales, falso para contario
        ///</summary>
        ///<return> Retorna verdadero o falso </return>
        public override bool Equals(object obj)
        {

            Habilidades h = (Habilidades)obj;
            return base.Equals(h);
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

        #region Metodos override
        /// <summary>
        /// Descripcion de la Habilidad
        /// </summary>
        /// <returns>Un string con la descripcion de la Habilidad</returns>
        public override string descripcion()
        {
            return "\nHabilidad: \n";
        }

        #endregion
    }
}