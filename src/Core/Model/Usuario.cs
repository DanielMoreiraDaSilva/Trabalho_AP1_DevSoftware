using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core
{
    public class Usuario
    {
        public int UsuarioId {get; set;}
        public string Nome {get; set;}
        public DateTime DataNascimento {get; set;}
        public string Email {get; set;}
        public Boolean TipoDeUsuario {get; set;}
        // nomes - voluntario e comprador
        public Guid Endereco {get; set;}
        public int ListaDeCompras {get; set; }
    }
}