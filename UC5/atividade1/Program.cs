using System;
namespace atividade1{
    class Program{
        static void Main(string[] args){
            
            Pedido pedido = new Pedido();
            string resposta = "s";

            do{
                ItemPedido item = new ItemPedido();

                Console.WriteLine("Informe a descrição do produto: ");
                item.desc = Console.ReadLine();

                Console.WriteLine("Informa o valor do produto: ");
                item.valor = double.Parse(Console.ReadLine());

                Console.WriteLine("Informa a quantidade do produto: ");
                item.quant = double.Parse(Console.ReadLine());

                pedido.adicionar(item);

                Console.WriteLine("Deseja continuar adicionando? (s/n)");
                resposta = Console.ReadLine();

                if (resposta == "n"){

                    Console.WriteLine(pedido.total());
                    
                }

            } while (resposta == "s");
            
            

        }
    }
}
