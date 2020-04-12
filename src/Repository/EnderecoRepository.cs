using System;
using Core;
using Core.Interface;

namespace Repository
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly Context context;
        public EnderecoRepository(Context context)
        {
            this.context = context;
        }
        public void AddEndereco(Endereco endereco)
        {
            context.Enderecos.Add(endereco);
            context.SaveChanges();
        }

        public void DeleteEndereco(Endereco endereco)
        {
            var enderecoRemove = context.Enderecos.Find(endereco.Id);
            context.Enderecos.Remove(endereco);
            context.SaveChanges();
        }

        public Endereco GetByIdEndereco(Guid Id)
        {
            return context.Enderecos.Find(Id);
        }

        public void UpdateEndereco(Endereco endereco)
        {
            context.Enderecos.Update(endereco);
            context.SaveChanges();
        }
    }
}