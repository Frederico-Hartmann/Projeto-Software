using Fabrica.Produtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fabrica.Criadores
{
    public abstract class FabricaTransporte
    {
        public abstract Transporte BuscaTransporte();
    }
}
