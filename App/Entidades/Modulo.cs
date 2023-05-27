using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wCut.App.Entidades
{
    public class Modulo
    {
        public int laterais { get; set; }
        public int pecaBase { get; set; }
        public int pecaSuperior { get; set; }
        public int prateleiras { get; set; }
        public int portas { get; set; }

        public Modulo(int laterais, int pecaBase, int pecaSuperior, int prateleiras, int portas)
        {

            this.laterais = laterais;
            this.pecaBase = pecaBase;
            this.pecaSuperior = pecaSuperior;
            this.prateleiras = prateleiras;
            this.portas = portas;
        }

    }
}
