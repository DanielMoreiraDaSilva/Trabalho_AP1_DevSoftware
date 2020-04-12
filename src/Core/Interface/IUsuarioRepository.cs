using System.Collections.Generic;
using Model.ViewModel;

namespace Core.Interface
{
    public interface IUsuarioRepository
    {
        List<Usuario> GetAll();
        Usuario GetByIdUsuario(int Id);

        void AddUsuario(Usuario usuario);
        void UpdateUsuario(Usuario usuario);
        void DeleteUsuario(Usuario usuario);
    }
}