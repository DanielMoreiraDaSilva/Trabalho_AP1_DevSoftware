using System;
using System.Collections.Generic;
using Core;
using Core.Interface;
using Model.ViewModel;
using Repository;
using Usuario = Core.Usuario;

namespace Business
{
    public class BusinessUsuario : IBusinessUsuario
    {
        private readonly IUsuarioRepository usuarioRepository;
        private readonly IEnderecoRepository enderecoRepository;
        public BusinessUsuario(IUsuarioRepository usuarioRepository, IEnderecoRepository enderecoRepository)
        {
            this.usuarioRepository = usuarioRepository;
            this.enderecoRepository = enderecoRepository;
        }
        public void AddUsuario(UsuarioViewModel usuarioViewModel)
        {

            if (usuarioViewModel.UsuarioId == 0)
            {
                usuarioViewModel.UsuarioId = new Random().Next(1111, 9999);

            }

            usuarioViewModel.Endereco.Id = Guid.NewGuid();

            var usuario = new Usuario()
            {
                UsuarioId = usuarioViewModel.UsuarioId,
                Nome = usuarioViewModel.Nome,
                Email = usuarioViewModel.Email,
                DataNascimento = usuarioViewModel.DataNascimento,
                TipoDeUsuario = usuarioViewModel.TipoDeUsuario,
                Endereco = usuarioViewModel.Endereco.Id
            };

            var endereco = new Endereco()
            {
                Id = usuarioViewModel.Endereco.Id,
                Bairro = usuarioViewModel.Endereco.Bairro,
                Cep = usuarioViewModel.Endereco.Cep,
                Cidade = usuarioViewModel.Endereco.Cidade,
                Complemento = usuarioViewModel.Endereco.Complemento,
                Estado = usuarioViewModel.Endereco.Estado,
                Rua = usuarioViewModel.Endereco.Rua,
                UsuarioId = usuarioViewModel.UsuarioId
            };

            usuarioRepository.AddUsuario(usuario);
            enderecoRepository.AddEndereco(endereco);
        }

        public void DeleteUsuario(int Id)
        {
            var usuario = usuarioRepository.GetByIdUsuario(Id);

            var endereco = enderecoRepository.GetByIdEndereco(usuario.Endereco);

            usuarioRepository.DeleteUsuario(usuario);
            enderecoRepository.DeleteEndereco(endereco);
        }

        public List<UsuarioViewModel> GetAll()
        {
            List<Usuario> listUsuarios = usuarioRepository.GetAll();
            var listUsuariosViewModel = new List<UsuarioViewModel>();

            for (int i = 0; i < listUsuarios.Count; i++)
            {
                var produtoVielModel = new UsuarioViewModel()
                {
                    DataNascimento = listUsuarios[i].DataNascimento,
                    Email = listUsuarios[i].Email,
                    Nome = listUsuarios[i].Nome,
                    TipoDeUsuario = listUsuarios[i].TipoDeUsuario,
                    UsuarioId = listUsuarios[i].UsuarioId,
                    Endereco = enderecoRepository.GetByIdEndereco(listUsuarios[i].Endereco)
                };


                if (produtoVielModel.Endereco == null)
                {
                    produtoVielModel.Endereco = new Endereco();
                }

                listUsuariosViewModel.Add(produtoVielModel);

            }

            return listUsuariosViewModel;

        }

        public UsuarioViewModel GetByIdUsuario(int Id)
        {
            Usuario usuario = usuarioRepository.GetByIdUsuario(Id);
            var usuarioViewlModel = new UsuarioViewModel()
            {
                DataNascimento = usuario.DataNascimento,
                Email = usuario.Email,
                Nome = usuario.Nome,
                TipoDeUsuario = usuario.TipoDeUsuario,
                UsuarioId = usuario.UsuarioId,
                Endereco = enderecoRepository.GetByIdEndereco(usuario.Endereco)
            };

            return usuarioViewlModel;
        }

        public void UpdateUsuario(UsuarioViewModel usuarioViewModel)
        {
            var usuario = new Usuario()
            {
                UsuarioId = usuarioViewModel.UsuarioId,
                Nome = usuarioViewModel.Nome,
                Email = usuarioViewModel.Email,
                DataNascimento = usuarioViewModel.DataNascimento,
                TipoDeUsuario = usuarioViewModel.TipoDeUsuario,
                Endereco = usuarioViewModel.Endereco.Id
            };

            var endereco = new Endereco()
            {
                Id = usuarioViewModel.Endereco.Id,
                Bairro = usuarioViewModel.Endereco.Bairro,
                Cep = usuarioViewModel.Endereco.Cep,
                Cidade = usuarioViewModel.Endereco.Cidade,
                Complemento = usuarioViewModel.Endereco.Complemento,
                Estado = usuarioViewModel.Endereco.Estado,
                Rua = usuarioViewModel.Endereco.Rua,
                UsuarioId = usuarioViewModel.UsuarioId
            };

            usuarioRepository.UpdateUsuario(usuario);
            enderecoRepository.UpdateEndereco(endereco);
        }
    }
}