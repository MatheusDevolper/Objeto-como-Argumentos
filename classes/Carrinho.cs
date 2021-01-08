using System;
using System.Collections.Generic;

namespace Objetos_com_Argumentos.classes
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }
        
        //Lista o carrinho de compras
        List<Produto> carrinho = new List <Produto>();

        //Método para ADICIONAR um produto ao carrinho
        public void Adicionar (Produto produto)
        {
            carrinho.Add(produto);
        }

        //Método para REMOVER um produto ao carrinho
        public void Remover (Produto produto)
        {
            carrinho.Remove(produto);
        }

        //Novo Produto utilizando o Código Já existente 
        public void Alterar(int _codigo, Produto _produtoNovo)
        {
            carrinho.Find(x => x.Codigo == _codigo).Nome = _produtoNovo.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _produtoNovo.Preco;
        }

        //Método para EXIBIR produtos e valores no carrinho
        public void ExibirCarrinho ()
        {
            if (carrinho != null)
            {
                foreach (Produto _produto in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Item: {_produto.Nome} - R$ {_produto.Preco.ToString("n2")}");
                    Console.ResetColor();                    
                }
                ExibirTotal();               
            }
        }

        //Método para CALCULAR os valores de produtos no carrinho
        public void ExibirTotal()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            if (carrinho != null)
            {
                foreach (Produto p in carrinho)
                {
                    ValorTotal += p.Preco;
                }
                Console.WriteLine($"\nValor Total: R$ {ValorTotal.ToString("n2")}");                
            }else
            {
                Console.WriteLine("Não há itens no carrinho!");
                
            }
            Console.ResetColor();
        }

        
    }

}