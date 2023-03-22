using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class Vendedor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [StringLength(250, MinimumLength = 10, ErrorMessage = "{0} deveria estar entre {2} e {1}")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Data Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Salario Base")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double SalarioBase { get; set; }

        public Departamento? Departamento { get; set;}
        public int DepartamentoId { get; set; }
        public ICollection<Vendas> Vendas { get; set; } = new List<Vendas>();

        public Vendedor()
        { 
        }

        public Vendedor(int id, string nome, string email, DateTime dataNascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AdicionarVenda(Vendas venda)
        { 
            Vendas.Add(venda);
        }

        public void RemoverVenda(Vendas venda)
        {
            Vendas.Remove(venda);
        }

        public double TotalVendas(DateTime dataInicial, DateTime dataFinal)
        {
            return Vendas.Where(venda => venda.Data >= dataInicial && venda.Data <= dataFinal).Sum(venda => venda.Total);
        }
    }
}