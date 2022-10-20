using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativa
{
    internal class BancoDadosSimulado
    {

        public static List<Produto> Produtos { get; set; }
        public static BindingList<Pedido> Pedidos { get; set; }

        static BancoDadosSimulado()
        {

            Produto abobora = new Produto(1, "Abobora", 2);
            Produto abacaxi = new Produto(2, "Abacaxi", 4);
            Produto abacate = new Produto(3, "Abacate", 8);
            Produto banana = new Produto(4, "Banana", 16);
            Produto caju = new Produto(5, "Caju", 32);
            Produto melancia = new Produto(6, "Melancia", 64);
            Produto uva = new Produto(7, "Uva", 2);
            Produto manga = new Produto(8, "Manga", 4);
            Produto jabuticaba = new Produto(9, "Jabuticaba", 8);


            Produtos = new List<Produto>();
            Produtos.Add(abobora);
            Produtos.Add(abacaxi);
            Produtos.Add(abacate);
            Produtos.Add(banana);
            Produtos.Add(caju);
            Produtos.Add(melancia);
            Produtos.Add(uva);
            Produtos.Add(manga);
            Produtos.Add(jabuticaba);


            Pedidos = new BindingList<Pedido>();
            
        }

        public static Produto LocalizarProdutoPorCodigo(Int64 codigo)
        {

            Produto listaProdutos = null;

            foreach (Produto produto in Produtos)
            {

                if (produto.Codigo == codigo)
                {

                    listaProdutos = produto;
                }
            }

            return listaProdutos;
        }

        public static List<Produto> LocalizarProdutoPorParteNome(String parte)
        {

            List<Produto> listaProdutos = new List<Produto>();

            foreach (Produto produto in Produtos)
            {

                if (produto.Nome.ToLower().Contains(parte.ToLower()))
                {

                    listaProdutos.Add(produto);
                }
            }

            return listaProdutos;
        }

        
            
        
    }
}
