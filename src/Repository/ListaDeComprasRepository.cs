using Core;
using Core.Interface;

namespace Repository
{
    public class ListaDeComprasRepository : IListaDeComprasRepository
    {
        private readonly Context context;
        public ListaDeComprasRepository(Context context)
        {
            this.context = context;
        }
        public void AddListaDeCompra(ListaDeCompras listaDeCompras)
        {
            context.Listas.Add(listaDeCompras);
            
        }

        public void DeleteListaDeCompras(ListaDeCompras listaDeCompras)
        {
            throw new System.NotImplementedException();
        }

        public ListaDeCompras GetListaDeCompras(int Id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateListaDeCompras(ListaDeCompras listaDeCompras)
        {
            throw new System.NotImplementedException();
        }
    }
}