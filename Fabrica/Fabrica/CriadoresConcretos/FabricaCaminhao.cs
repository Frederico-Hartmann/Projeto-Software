using Fabrica.Criadores;
using Fabrica.Produtos;
using Fabrica.ProdutosConcretos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fabrica.CriadoresConcretos
{
    public class FabricaCaminhao : FabricaTransporte
    {
        private int _PesoCarga;

        public FabricaCaminhao(int PesoCarga)
        {
            this._PesoCarga = PesoCarga;
        }

        public override Transporte BuscaTransporte()
        {
            return new Caminhao(_PesoCarga);
        }
    }
}
