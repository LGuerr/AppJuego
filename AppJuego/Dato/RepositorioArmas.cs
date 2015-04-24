using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppJuego.Dato
{
    public class RepositorioArmas
    {
        static List<Armas> armas = new List<Armas>();

        public void addArma(Armas a)
        {
            armas.Add(a);
        }

        public List<Armas> getListaArmas()
        {
            return armas;
        }

        public IEnumerable<Armas> getArmas()
        {
            return armas;
        }

        public IEnumerable<string> getNombreArmas()
        {
            List<string> nombres = new List<string>();
            foreach (Arma a in armas)
            {
                if (!nombres.Contains(a.NombreArma)) nombres.Add(a.NombreArma);
            }
            return nombres;
        }

        public bool Contains(Arma a)
        {
            foreach (Arma ar in armas)
            {
                if (a.Equals(ar)) return true;
            }
            return false;
        }
    }
}