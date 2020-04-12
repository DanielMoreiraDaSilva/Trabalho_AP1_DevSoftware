using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core{

    public class Endereco
    {
        public Endereco()
        {
        }
        public Guid Id {get; set;}
        public string Cep {get; set;}
        public string Estado {get; set;}
        public string Cidade {get; set;}
        public string Bairro {get; set;}
        public string Rua {get; set;}
        public int Numero {get;}
        public string Complemento {get; set;}
        public int UsuarioId {get; set;}
    }
}