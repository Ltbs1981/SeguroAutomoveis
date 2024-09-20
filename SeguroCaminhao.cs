using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguroAutomoveis
{
    public class SeguroCaminhao : Seguro
    {

        public double PremioCaminhaoComBaseCarga { get; set; }
        public bool CapacidadeCarga { get; set; }

        public SeguroCaminhao(string marcaVeiculo, string anoVeiculo, double valorVeiculo, double franquia, int duracaoEmAnos)
            : base(marcaVeiculo, anoVeiculo, valorVeiculo, franquia, duracaoEmAnos)
        {
            PremioCaminhaoComBaseCarga = 0.15;
            CapacidadeCarga = false;
        }

        public override double ValorSeguro()
        {
            if (CapacidadeCarga)
            {
                return ValorVeiculo * 0.10 + Franquia + PremioCaminhaoComBaseCarga;
            }
            else
            {
                return ValorVeiculo * 0.02 + Franquia;
            }
        }
        public void VerificaCarga(int toneladas)
        {
            CapacidadeCarga = toneladas > 5;
        }
    }
}