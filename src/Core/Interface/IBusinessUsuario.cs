using System;
using System.Collections.Generic;
using Model.ViewModel;

namespace Core.Interface
{
    public interface IBusinessUsuario
    {
        List<UsuarioViewModel> GetAll();
        UsuarioViewModel GetByIdUsuario(int Id);

        void AddUsuario(UsuarioViewModel usuario);
        void UpdateUsuario(UsuarioViewModel usuario);
        void DeleteUsuario(int Id);
    }
}