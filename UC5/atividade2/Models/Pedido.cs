using System.Collections.Generic;
namespace atividade2.Models{
    public class Pedido{

        List<ItemPedido> lista = new List<ItemPedido>();

        public List<ItemPedido> Listar(){
            return lista;
        }
        
        public void adicionar (ItemPedido item){
            lista.Add(item);
        }

        
    }
}