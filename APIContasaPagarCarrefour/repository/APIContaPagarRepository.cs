using APICarrefourContasPagar.Dominio;
using APICarrefourContasPagar.Interface;
using APIContasaPagarCarrefour.dominio;
using Microsoft.EntityFrameworkCore;


namespace APIContasaPagarCarrefour.Repository

{
    public class APIContaPagarRepository : IContaPagarRepository
    {
        private  ContasContext _context;




        public APIContaPagarRepository()
        {
            _context = new ContasContext();
        }


        public List<ContaPagar> ObterContasPagar()
        {



            return _context.Set<ContaPagar>().ToList();






        }

        public List<ContaPagar> ObterContasPagarDia(DateTime data)
        {
            var resultados = _context.Set<ContaPagar>()
                .Where(c => c.DataPagamento == data.Date)
                .GroupBy(c => c.Fornecedor)
                .Select(g => new
                {
                    Fornecedor = g.Key,
                    Soma = g.Sum(c => c.Valor)
                })
                .ToList();

            return resultados.Cast<ContaPagar>().ToList(); ;
        }

        public ContaPagar ObterContaPagarPorId(int id)
        {
            return _context.Set<ContaPagar>().Find(id);
        }

        public void AdicionarContaPagar(ContaPagar contaPagar)
        {
          
            _context.Set<ContaPagar>().Add(contaPagar);
            _context.SaveChanges();
        }

        public void AtualizarContaPagar(ContaPagar contaPagar)
        {
            _context.Entry(contaPagar).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void RemoverContaPagar(int id)
        {
            var contaPagar = _context.Set<ContaPagar>().Find(id);
            _context.Set<ContaPagar>().Remove(contaPagar);
            _context.SaveChanges();
        }
    }

}
