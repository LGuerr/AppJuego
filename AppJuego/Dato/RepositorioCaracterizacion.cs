using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppJuego.Dato
{
    public class RepositorioCaracterizacion
    {
     static List<Caracterizacion> caracteristicas = new List<Caracterizacion>();

        static RepositorioCaracterizacion()
        {
            caracteristicas.Add(new Caracterizacion("Elija una opción", ""));
            caracteristicas.Add(new Caracterizacion("Poder", ""));
            caracteristicas.Add(new Caracterizacion("Habilidad", ""));
            caracteristicas.Add(new Caracterizacion("Debilidad", ""));
            caracteristicas.Add(new Caracterizacion("Arma", ""));
            caracteristicas.Add(new Caracterizacion("Personalidad", ""));
        }

        public void addCaracteristica(Caracterizacion c)
        {
            caracteristicas.Add(c);
        }

        public IEnumerable<Caracterizacion> getCaracteristicas()
        {
            return caracteristicas;
        }

        public List<Caracterizacion> getListaCaracteristicas()
        {
            return caracteristicas;
        }

        /*public IEnumerable<string> getNombresCaracteristicas()
        {
            List<string> nombres = new List<string>();
            foreach (Caracteristica c in caracteristicas)
            {
                if (!nombres.Contains(c.Nombre)) nombres.Add(c.Nombre);
            }
            return nombres;
        }*/


        public bool Contains(Caracterizacion c)
        {
            foreach (Caracterizacion car in caracteristicas)
            {
                if (c.Equals(car)) return true;
            }
            return false;
        }
    }
}