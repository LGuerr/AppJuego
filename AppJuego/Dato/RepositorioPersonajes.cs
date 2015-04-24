using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppJuego.Dato
{
    public class RepositorioPersonajes
    {

        #region personajes
        static List<Personajes> personajes = new List<Personajes>();

        
        public void addPersonaje(Personajes p)
        {
            if(!contains(p.Nombre)) personajes.Add(p);
        }

        public void EditarCaracteristicasPersonaje(string nombre, List<Caracterizacion> carac, List<Armas> armas)
        {
            foreach (Personajes p in personajes)
            {
                if (p.Nombre == nombre)
                {
                    p.Caracteristicas = carac;
                    p.Armas = armas;
                }
            }
        }

        public IEnumerable<Personajes> getPersonajes()
        {
            return personajes;
        }

        public List<Personajes> getListaPersonajes()
        {
            return personajes;
        }

        //Verificar si existe el personaje en el repositorio
        public bool contains(string n)
        {
            bool c = personajes.Exists(x => x.Nombre == n);
            return c;
        }
        #endregion       
        
    }
}