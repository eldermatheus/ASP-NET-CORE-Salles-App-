using SalesWebMvc.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class Vendas
    {
        [Key]
        public int Id { get; set; }

        public DateTime Data { get; set; }
        public double Total { get; set; }        
        public Status Situacao { get; set; }
        public Vendedor Vendedor { get; set; }

        public Vendas()
        { 
        }

        public Vendas(int id, DateTime data, double total, Status situacao, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Total = total;
            Situacao = situacao;
            Vendedor = vendedor;
        }
    }
}
