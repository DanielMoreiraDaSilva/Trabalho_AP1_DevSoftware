using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Core
{
    public class ListaDeCompras
    {
        [Key]
        int ListaDeComprasId {get; set;}
        DateTime DataCriacao {get; set;}
        DateTime DataPrevisaoEntrega {get; set;}
        ICollection<Produto> IdProdutos {get; set;}
    }
}