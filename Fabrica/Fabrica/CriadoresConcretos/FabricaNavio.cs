using Fabrica.Criadores;
using Fabrica.Produtos;
using Fabrica.ProdutosConcretos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fabrica.CriadoresConcretos
{
    public class FabricaNavio : FabricaTransporte
    {
        private int _PesoCarga;

        public FabricaNavio(int PesoCarga)
        {
            this._PesoCarga = PesoCarga;
        }

        public override Transporte BuscaTransporte()
        {
            return new Navio(_PesoCarga);
        }
    }
}
