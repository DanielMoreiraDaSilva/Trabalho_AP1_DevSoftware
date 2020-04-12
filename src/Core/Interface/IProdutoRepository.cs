using System.Collections.Generic;

namespace Core.Interface
{
    public interface IProdutoRepository
    {
        List<Produto> GetAll();
        Produto GetByIdProduto(int Id);
        void AddProduto(Produto produto);
        void UpdateProduto(Produto produto);
        void DeleteProduto(int Id);
    }
}