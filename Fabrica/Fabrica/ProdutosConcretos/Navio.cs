using Fabrica.Produtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fabrica.ProdutosConcretos
{
    public class Navio : Transporte
    {
        private readonly string _Meio;
        private int _PesoCarga;

        public Navio(int PesoCarga)
        {
            this._Meio = "Navio";
            this._PesoCarga = PesoCarga;
        }

        public override string Meio
        {
            get => this._Meio;
        }

        public override int PesoCargaMaxima
        {
            get => this._PesoCarga;
            set => this._PesoCarga = value;
        }
    }
}
