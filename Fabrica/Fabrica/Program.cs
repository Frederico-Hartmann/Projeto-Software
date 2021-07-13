using Fabrica.Criadores;
using Fabrica.CriadoresConcretos;
using Fabrica.Produtos;
using System;

namespace Fabrica
{
    class Program
    {
        static void Main(string[] args)
        {
            FabricaTransporte fabricaTransporte = null;
            Console.Write("Digite o meio de transporte:");
            string console = Console.ReadLine();

            switch (console.ToLower())
            {
                case "c":
                    fabricaTransporte = new FabricaCaminhao(16);
                    break;
                case "n":
                    fabricaTransporte = new FabricaNavio(30);
                    break;
            }

            Transporte transporte = fabricaTransporte.BuscaTransporte();
            Console.WriteLine("O transporte do tipo {0} da empresa suportam até {1} toneladas",
                transporte.Meio, transporte.PesoCargaMaxima);
        }
    }
}
