using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastecerVeiculo.Entities
{
    internal class Veiculo
    {
        public Veiculo(string Nome, string Marca, int capacidadeDoTanque, int litrosNoTanque)
        {
            this.Nome = Nome;
            this.Marca = Marca;
            this.capacidadeDoTanque = capacidadeDoTanque;
            this.litrosNoTanque = litrosNoTanque;
        }

        public string Nome;

        public string Marca;

        public int capacidadeDoTanque;

        public int litrosNoTanque;

    }
}