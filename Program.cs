using System;
using Objetos_com_Argumentos.classes;

namespace Objetos_com_Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto i1 = new Produto (1001, "Cueca Boxer Lupo", 289.90f);
            Produto i2 = new Produto (1002, "Mizuno Pro 9", 89.90f);
            Produto i3 = new Produto (1003, "Cinto John John", 99.90f);
            Produto i4 = new Produto (1004, "Boné New Era", 49.90f);
            Produto i5 = new Produto (1005, "Nike Air Max 90", 14.90f);
            Produto i6 = new Produto (1006, "Calça Calvin Klein ", 69.90f);

            Carrinho carrinho = new Carrinho();
            carrinho.Adicionar(i1);
            carrinho.Adicionar(i3);
            carrinho.Adicionar(i5);
            carrinho.Adicionar(i4);

            carrinho.ExibirCarrinho();

            carrinho.Remover(i4);

            carrinho.ExibirCarrinho();
        }
    }
}
