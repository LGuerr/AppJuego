using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppJuego
{
    public class Habilidades : Caracterizacion
    {
        #region Atributos
        Boolean Agilidad, Evacion, Correr, Saltar;

        public Boolean agilidad
        {
            get { return agilidad; }
            set { Agilidad = value; }

        }
        public Boolean evacion
        {
            get { return evacion; }
            set { evacion = value; }
        }
        public Boolean correr
        {
            get { return correr; }
            set { correr = value; }

        }
        public Boolean saltar
        {
            get { return saltar; }
            set { saltar = value; }
        }
        #region Constructores

        public Habilidades()
            : base()
        {
            this.saltar = true;
            this.correr = true;
            this.agilidad = true;
            this.evacion = true;

        }

        /// <summary>
        /// Constructor de Inicializacion de una Habilidad
        /// </summary>
        /// <param name="nombre">Nombre de la Habilidad</param>
        /// <param name="tipo">Tipo de Habilidad</param>
        public Habilidades(string nombre, string tipo, Boolean saltar, Boolean correr,
            Boolean agilidad, Boolean evacion)
            : base(nombre, tipo)
        {
            this.evacion = true;
            this.saltar = true;
            this.correr = true;
        }

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