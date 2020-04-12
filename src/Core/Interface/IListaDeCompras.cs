namespace Core.Interface
{
    public interface IListaDeComprasRepository
    {
        ListaDeCompras GetListaDeCompras(int Id);
        void AddListaDeCompra(ListaDeCompras listaDeCompras);
        void UpdateListaDeCompras(ListaDeCompras listaDeCompras);
        void DeleteListaDeCompras(ListaDeCompras listaDeCompras);
    }
}