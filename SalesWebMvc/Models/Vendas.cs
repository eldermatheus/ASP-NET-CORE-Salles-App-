using SalesWebMvc.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class Vendas
    {
        [Key]
        public int Id { get; set; }

        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Total { get; set; }        
        public Situacao Situacao { get; set; }
        public Vendedor Vendedor { get; set; }

        public Vendas()
        { 
        }

        public Vendas(int id, DateTime data, double total, Situacao situacao, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Total = total;
            Situacao = situacao;
            Vendedor = vendedor;
        }
    }
}
