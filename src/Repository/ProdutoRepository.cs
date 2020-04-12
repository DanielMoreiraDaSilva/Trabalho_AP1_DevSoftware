using System.Collections.Generic;
using System.Linq;
using Core;
using Core.Interface;

namespace Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly Context context;
        public ProdutoRepository(Context context)
        {
            this.context = context;
        }

        public void AddProduto(Produto produto)
        {
            context.Produtos.Add(produto);
            context.SaveChanges();
        }

        public void DeleteProduto(int Id)
        {
            var produtoRemove = context.Produtos.Find(Id);
            context.Produtos.Remove(produtoRemove);
            context.SaveChanges();            
        }

        public List<Produto> GetAll()
        {
            return context.Produtos.ToList();
        }

        public Produto GetByIdProduto(int Id)
        {
            return context.Produtos.Find(Id);
        }

        public void UpdateProduto(Produto produto)
        {
            context.Produtos.Update(produto);
            context.SaveChanges();
        }
    }
}