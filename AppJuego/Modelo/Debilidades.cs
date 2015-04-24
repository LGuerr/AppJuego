using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppJuego
{
    public class Debilidades : Caracterizacion
    {
        #region Constructores
        /// <summary>
        /// Constructor por defecto de Una Debilidad
        /// </summary>
        public Debilidades()
            : base() { }

        /// <summary>
        /// Constructor de Inicializacion de una Debilidad
        /// </summary>
        /// <param name="nombre">Nombre de la Debilidad</param>
        /// <param name="tipo">Tipo de Debilidad</param>
        public Debilidades(string nombre, string tipo)
            : base(nombre, tipo) { }

        #endregion

        #region Metodos override base
        /// <summary>
        /// Retorna la descripición de la Debilidad
        /// </summary>
        /// <returns>Retorna un string con la descripición de la Debilidad</returns>
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

            Debilidades h = (Debilidades)obj;
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
        /// Descripcion de la Debilidad
        /// </summary>
        /// <returns>Un string con la Descripcion de la Habilidad</returns>
        public override string descripcion()
        {
            return "\nDebilidades: \n";
        }

        #endregion
    }
}