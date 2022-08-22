using System;
namespace ProjetoLoja{
    class Program{
        static void Main(string[] args){
            
            public  string resposta = "s";
            CadastrandoProduto cadastro = new CadastrandoProduto();

           do{
	            Produto item = new Produto();
		
		        Console.WriteLine("Qual o nome do produto?");
		        item.desc = Console.ReadLine();
	
	            Console.WriteLine("Qual a quantidade do produto?");
                item.quant = double.Parse(Console.ReadLine());
		
		        Console.WriteLine("Qual a quantidade do produto?");
		        item.quant = double.Parse(Console.ReadLine);
		
	            Console.WriteLine("Deseja cadastrar mais um pedido?");
	            resposta = Console.ReadLine();
            } while (resposta == "s");


        }
    }
}
