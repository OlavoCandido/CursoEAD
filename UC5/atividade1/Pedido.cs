using System.Collections.Generic;
namespace atividade1{
    public class Pedido{

        private List<ItemPedido> lista = new List<ItemPedido>();

        public void adicionar (ItemPedido item){
            lista.Add(item);
        }

        public double total (){

            double total = 0;
            for (int i = 0; i < lista.Count; i++){

                total = lista[i].valor * lista[i].quant + total;
                
            }

            return total;
        }
        
    }
}