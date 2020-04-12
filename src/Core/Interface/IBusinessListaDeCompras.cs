using System;
using System.Collections.Generic;
using Model.ViewModel;

namespace Core.Interface
{
    public interface IBusinessListaDeCompras
    {
        ListaDeCompras GetByIdListaDeCompras(int Id);

        void AddListaDeCompras(ListaDeCompras listaDeCompras);
        void UpdateListaDeCompras(ListaDeCompras listaDeCompras);
        void DeleteListaDeCompras(int Id);
    }
}