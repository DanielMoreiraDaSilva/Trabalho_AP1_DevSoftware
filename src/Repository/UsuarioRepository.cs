using System.Collections.Generic;
using Core;
using Core.Interface;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly Context  context; 
        public UsuarioRepository(Context context)
        {
            this.context = context;   
        }
        public void AddUsuario(Usuario usuario)
        {
            // context.Enderecos.Add(new Endereco(){ID = 1234 });

            context.Usuarios.Add(usuario);
            
            context.SaveChanges();
        }

        public void DeleteUsuario(Usuario usuario)
        {
            var usuarioRemove = context.Usuarios.Find(usuario.UsuarioId);
            context.Usuarios.Remove(usuarioRemove);
            context.SaveChangesAsync();
        }

        public List<Usuario> GetAll()
        {
            return context.Usuarios.ToList();
        }

        public Usuario GetByIdUsuario(int Id)
        {
            return context.Usuarios.Find(Id);
        }

        public void UpdateUsuario(Usuario usuario)
        {
            context.Usuarios.Update(usuario);
            context.SaveChanges();
        }
    }
}