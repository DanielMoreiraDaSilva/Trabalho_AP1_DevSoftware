using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Core
{
    public class ListaDeComprasViewModel
    {
        
        int Id {get; set;}
        DateTime DataCriacao {get; set;}
        DateTime DataPrevisaoEntrega {get; set;}
        // [ForeignKey("ListaDeProdutos")]
        List<Produto> ListaDeProdutos {get; set;}
    }
}