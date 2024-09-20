using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguroAutomoveis
{
    class Cliente
    {
        public string Nome { get; set; }
        private List<Seguro> listaSeguros;

        public Cliente(string nome)
        {
            Nome = nome;
            listaSeguros = new List<Seguro>();
        }

        public double TotalSeguros()
        {
            double total = 0;
            foreach (var seguro in listaSeguros)
            {
                total += seguro.ValorSeguro();
            }
            return total;
        }

        public void AdquirirSeguro(Seguro seguro)
        {
            listaSeguros.Add(seguro);
            Console.WriteLine("Tudo certo, seguro adquirido!");
        }

        public void ListaDeSeguros()
        {
            if (listaSeguros.Count == 0)
            {
                Console.WriteLine("Não há seguros registrados em seu nome.");
                return;
            }

            for (int i = 0; i < listaSeguros.Count; i++)
            {
                var seguro = listaSeguros[i];
                Console.WriteLine($"Seguro {i + 1}:");
                Console.WriteLine($"  Marca: {seguro.MarcaVeiculo}");
                Console.WriteLine($"  Ano: {seguro.AnoVeiculo}");
                Console.WriteLine($"  Valor do Veículo: {seguro.ValorVeiculo:C}");
                Console.WriteLine($"  Franquia: {seguro.Franquia:C}");
                Console.WriteLine($"  Duração: {seguro.DuracaoEmAnos} anos");

                if (seguro is SeguroCaminhao caminhao && caminhao.CapacidadeCarga)
                {
                    Console.WriteLine("  Capacidade de carga: acima de 5 toneladas");
                }
            }
        }
    }
}
