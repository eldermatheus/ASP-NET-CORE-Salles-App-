using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class DataSeedService
    {
        private SalesWebMvcContext _context;

        public DataSeedService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departamento.Any() ||
                _context.Vendedor.Any() ||
                _context.Vendas.Any())
            {
                return;
            }

            Departamento departamento1 = new Departamento(1, "Computadores");
            Departamento departamento2 = new Departamento(2, "Eletronicos");
            Departamento departamento3 = new Departamento(3, "Roupas");
            Departamento departamento4 = new Departamento(4, "Livros");
            Departamento departamento5 = new Departamento(5, "Autopeças");

            Vendedor vendedor1 = new Vendedor() { Id = 1, Nome = "Elder", Email = "elder@hotmail.com", DataNascimento = DateTime.Parse("01/05/2000"), SalarioBase = 2500, Departamento = departamento1 };
            Vendedor vendedor2 = new Vendedor() { Id = 2, Nome = "Maria", Email = "maria@hotmail.com", DataNascimento = DateTime.Parse("01/12/2001"), SalarioBase = 1100, Departamento = departamento2 };
            Vendedor vendedor3 = new Vendedor() { Id = 3, Nome = "Joao", Email = "joao@hotmail.com", DataNascimento = DateTime.Parse("21/05/1994"), SalarioBase = 1500, Departamento = departamento3 };
            Vendedor vendedor4 = new Vendedor() { Id = 4, Nome = "Junior", Email = "junior@hotmail.com", DataNascimento = DateTime.Parse("30/09/1989"), SalarioBase = 3500, Departamento = departamento4 };
            Vendedor vendedor5 = new Vendedor() { Id = 5, Nome = "Lucas", Email = "lucas@hotmail.com", DataNascimento = DateTime.Parse("17/01/1994"), SalarioBase = 1750, Departamento = departamento5 };

            Vendas venda1 = new Vendas() { Id = 1, Data = DateTime.Parse("17/1/2023").ToLocalTime(), Total = 70, Situacao = Situacao.Faturado, Vendedor = vendedor1 };
            Vendas venda2 = new Vendas() { Id = 2, Data = DateTime.Parse("6/1/2023").ToLocalTime(), Total = 120, Situacao = Situacao.Pendente, Vendedor = vendedor2 };
            Vendas venda3 = new Vendas() { Id = 3, Data = DateTime.Parse("3/2/2023").ToLocalTime(), Total = 85, Situacao = Situacao.Faturado, Vendedor = vendedor3 };
            Vendas venda4 = new Vendas() { Id = 4, Data = DateTime.Parse("5/3/2023").ToLocalTime(), Total = 120, Situacao = Situacao.Cancelado, Vendedor = vendedor4 };
            Vendas venda5 = new Vendas() { Id = 5, Data = DateTime.Parse("12/11/2023").ToLocalTime(), Total = 360, Situacao = Situacao.Pendente, Vendedor = vendedor5 };
            Vendas venda6 = new Vendas() { Id = 6, Data = DateTime.Parse("12/1/2023").ToLocalTime(), Total = 35, Situacao = Situacao.Cancelado, Vendedor = vendedor1 };
            Vendas venda7 = new Vendas() { Id = 7, Data = DateTime.Parse("8/3/2023").ToLocalTime(), Total = 80, Situacao = Situacao.Cancelado, Vendedor = vendedor2 };
            Vendas venda8 = new Vendas() { Id = 8, Data = DateTime.Parse("5/12/2023").ToLocalTime(), Total = 370, Situacao = Situacao.Faturado, Vendedor = vendedor3 };
            Vendas venda9 = new Vendas() { Id = 9, Data = DateTime.Parse("2/11/2023").ToLocalTime(), Total = 800, Situacao = Situacao.Cancelado, Vendedor = vendedor4 };
            Vendas venda10 = new Vendas() { Id = 10, Data = DateTime.Parse("6/2/2023").ToLocalTime(), Total = 750, Situacao = Situacao.Pendente, Vendedor = vendedor5 };
            Vendas venda11 = new Vendas() { Id = 11, Data = DateTime.Parse("4/5/2023").ToLocalTime(), Total = 90, Situacao = Situacao.Pendente, Vendedor = vendedor1 };
            Vendas venda12 = new Vendas() { Id = 12, Data = DateTime.Parse("8/10/2023").ToLocalTime(), Total = 400, Situacao = Situacao.Faturado, Vendedor = vendedor2 };
            Vendas venda13 = new Vendas() { Id = 13, Data = DateTime.Parse("15/7/2023").ToLocalTime(), Total = 420, Situacao = Situacao.Faturado, Vendedor = vendedor3 };
            Vendas venda14 = new Vendas() { Id = 14, Data = DateTime.Parse("8/5/2023").ToLocalTime(), Total = 140, Situacao = Situacao.Pendente, Vendedor = vendedor4 };
            Vendas venda15 = new Vendas() { Id = 15, Data = DateTime.Parse("8/1/2023").ToLocalTime(), Total = 500, Situacao = Situacao.Pendente, Vendedor = vendedor5 };
            Vendas venda16 = new Vendas() { Id = 16, Data = DateTime.Parse("23/9/2023").ToLocalTime(), Total = 1000, Situacao = Situacao.Cancelado, Vendedor = vendedor1 };
            Vendas venda17 = new Vendas() { Id = 17, Data = DateTime.Parse("24/4/2023").ToLocalTime(), Total = 130, Situacao = Situacao.Faturado, Vendedor = vendedor2 };
            Vendas venda18 = new Vendas() { Id = 18, Data = DateTime.Parse("9/6/2023").ToLocalTime(), Total = 110, Situacao = Situacao.Cancelado, Vendedor = vendedor3 };
            Vendas venda19 = new Vendas() { Id = 19, Data = DateTime.Parse("26/8/2023").ToLocalTime(), Total = 1200, Situacao = Situacao.Cancelado, Vendedor = vendedor4 };
            Vendas venda20 = new Vendas() { Id = 20, Data = DateTime.Parse("25/2/2023").ToLocalTime(), Total = 150, Situacao = Situacao.Faturado, Vendedor = vendedor5 };
            Vendas venda21 = new Vendas() { Id = 21, Data = DateTime.Parse("11/1/2023").ToLocalTime(), Total = 280, Situacao = Situacao.Cancelado, Vendedor = vendedor1 };
            Vendas venda22 = new Vendas() { Id = 22, Data = DateTime.Parse("2/7/2023").ToLocalTime(), Total = 30, Situacao = Situacao.Pendente, Vendedor = vendedor2 };
            Vendas venda23 = new Vendas() { Id = 23, Data = DateTime.Parse("3/4/2023").ToLocalTime(), Total = 230, Situacao = Situacao.Cancelado, Vendedor = vendedor3 };
            Vendas venda24 = new Vendas() { Id = 24, Data = DateTime.Parse("15/3/2023").ToLocalTime(), Total = 170, Situacao = Situacao.Faturado, Vendedor = vendedor4 };
            Vendas venda25 = new Vendas() { Id = 25, Data = DateTime.Parse("14/6/2023").ToLocalTime(), Total = 20, Situacao = Situacao.Cancelado, Vendedor = vendedor5 };
            Vendas venda26 = new Vendas() { Id = 26, Data = DateTime.Parse("25/8/2023").ToLocalTime(), Total = 1020, Situacao = Situacao.Pendente, Vendedor = vendedor1 };
            Vendas venda27 = new Vendas() { Id = 27, Data = DateTime.Parse("15/5/2023").ToLocalTime(), Total = 200, Situacao = Situacao.Cancelado, Vendedor = vendedor2 };
            Vendas venda28 = new Vendas() { Id = 28, Data = DateTime.Parse("26/12/2023").ToLocalTime(), Total = 150, Situacao = Situacao.Faturado, Vendedor = vendedor3 };
            Vendas venda29 = new Vendas() { Id = 29, Data = DateTime.Parse("12/6/2023").ToLocalTime(), Total = 170, Situacao = Situacao.Faturado, Vendedor = vendedor4 };
            Vendas venda30 = new Vendas() { Id = 30, Data = DateTime.Parse("23/10/2023").ToLocalTime(), Total = 300, Situacao = Situacao.Pendente, Vendedor = vendedor5 };

            _context.Departamento.AddRange(departamento1, departamento2, departamento3, departamento4, departamento5);
            _context.Vendedor.AddRange(vendedor1, vendedor2, vendedor3, vendedor4, vendedor5);
            _context.Vendas.AddRange(
                venda1, venda2, venda3, venda4, venda5, venda6, venda7, venda8, venda9, venda10,
                venda11, venda12, venda13, venda14, venda15, venda16, venda17, venda18, venda19, venda20,
                venda21, venda22, venda23, venda24, venda25, venda26, venda27, venda28, venda29, venda30
            );

            _context.SaveChanges();
        }
    }
}
