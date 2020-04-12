using System;
using Core;

namespace Model.ViewModel
{
    public class UsuarioViewModel
    {
        public int UsuarioId {get; set;}
        public string Nome {get; set;}
        public DateTime DataNascimento {get; set;}
        public string Email {get; set;}
        public Boolean TipoDeUsuario {get; set;}
        // nomes - voluntario e comprador
        public Endereco Endereco {get; set;}
    }
}