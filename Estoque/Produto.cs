    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Estoque
    {
        class Produto
        {
            private int qtdExistente;
            public string Nome { get; set; }
            public decimal Preco { get; set; }
            public int Quantidade { get; set; }
            public string Descricao { get; set; }
            public string Disponivel
            {
                get
                {
                    return qtdExistente > 0 ? "Disponível" : "Indisponível";
                }
            }
            public int QuantidadeDisponivel
            {
                get
                {
                    return qtdExistente;    
                }
                set
                {
                    if(value >= 0)
                    {
                        qtdExistente += value;
                    }
                }
            }
            public DateTime DataEntrada { get; private set; }


            public Produto(string nome, decimal preco, int quantidade, string descricao)
            {   
                Nome = nome;
                Preco = preco;
                Quantidade = quantidade;
                Descricao = descricao;
                DataEntrada = DateTime.Now;
                qtdExistente = quantidade;
            }
        }
    }
