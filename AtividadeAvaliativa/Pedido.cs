using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeAvaliativa
{
    internal class Pedido
    {

        public static Int64 Serial { get; private set; }
        public Int64 NotaFiscal { get; set; }
        public List<Item> Itens { get; set; }


        static Pedido()
        {

            Serial = Convert.ToInt64(DateTime.Now.Year.ToString().Substring(2)) * 1000000;
        }
        public Pedido()
        {

            Itens = new List<Item>();

            NotaFiscal = Serial++;
        }

        public void AdicionarItem(Item item)
        {

            Itens.Add(item);
        }

        public Decimal CalcularTotal()
        {
            Decimal total = 0;
            foreach (Item item in Itens)
            {
                total += item.CalcularTotal();
            }

            return total;
        }
        public override string ToString()
        {

            return $"Nº{NotaFiscal} " + "R$" + CalcularTotal();
        }
    }
}
