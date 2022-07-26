using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.src {
    public class Celular {

        string Marca { get; set; }

        string Modelo { get; set; }

        int AnoLancamento { get; set; }

        double Preco { get; set; }

        public Celular(string marca, string modelo, int anoLancamento, double preco) {
            Marca = marca;
            Modelo = modelo;
            AnoLancamento = anoLancamento;
            Preco = preco;
        }
        public string Toque() {
            return "O modelo Iphone é o única que tem um toque diferenciado: Trim, Trim";
        }
        public override string ToString() {
            return ($"Este é um celular da marca {Marca} sendo do modelo {Modelo}, " +
                $"com ano de lançamento em {AnoLancamento} e com um preço de {Preco} R$.");
        }
    }
}

//enum Categ {
//    Botao,
//    liga,
//    desliga,
//    tela
//}
