using System;
using System.Collections.Generic;
using System.Text;

namespace Fabrica.Produtos
{
    public abstract class Transporte
    {
        public abstract string Meio { get; }
        public abstract int PesoCargaMaxima { get; set; }
    }
}
