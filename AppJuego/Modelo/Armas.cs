using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppJuego

{
    public class Armas : Caracterizacion
    {

        private string nombreArma;
        private double calibre;
        private double precision;


        public string NombreArma
        {
            get { return nombreArma; }
            set { nombreArma = value; }
        }

        public double Calibre
        {
            get { return calibre; }
            set { calibre = value; }
        }

        public double Precision
        {
            get { return precision; }
            set { precision = value; }
        }



        public Armas(string tipo, string nombre, double calibre, double precision) 
            : base("Arma",tipo){
            //lo que en la clase base corresponde a valor, aquí es el tipo de arma, es decir Caracteristica de nombre "Arma", con valor "De fuego"
            this.nombreArma = nombre;
            this.calibre = calibre;
            this.precision = precision;
        }

        public override string ToString()
        {
            return "\n************* ARMA ***************" +
                        "\nTipo de arma: " + this.Tipo +
                        "\nNombre del arma: " + this.NombreArma +
                        "\nCalibre: " + this.Calibre +
                        "\nPrecisión: " + this.Precision;
        }

        public override bool Equals(object obj)
        {
            Armas a = obj as Armas;
            return (a.Nombre == this.Nombre && a.Tipo == this.Tipo && a.NombreArma == this.nombreArma && a.Calibre == this.calibre && a.precision == this.precision);
        }
    }
}