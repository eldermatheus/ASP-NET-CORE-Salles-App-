using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class Vendedor
    {
        [Key]
        public int Id { get; set; }
        
        public string Nome { get; set; }
        public string Email { get; set; }        
        public DateTime DataNascimento { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set;}
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