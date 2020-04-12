using System.ComponentModel.DataAnnotations;

namespace Core
{
    public class Produto
    {
        [Key]
        int ProdutoId {get; set;}
        string Nome {get; set;}
        float Valor {get; set;}
        string Marca {get; set;}
        int ListaDeComprasId {get; set;}
        ListaDeCompras ListaDeCompras {get;set;}
    }
}