using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppJuego
{
    public interface IFicha
    {
        void add(Caracterizacion caracteristica);

        void liga(string liga);

        void enemigo(Personajes enemigo);
    }
}
