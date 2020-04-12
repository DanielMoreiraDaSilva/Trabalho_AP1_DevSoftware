using System;
using System.Collections.Generic;

namespace Core.Interface
{
    public interface IEnderecoRepository
    {
        Endereco GetByIdEndereco(Guid Id);
        void AddEndereco(Endereco endereco);
        void UpdateEndereco(Endereco endereco);
        void DeleteEndereco(Endereco endereco);
    }
}