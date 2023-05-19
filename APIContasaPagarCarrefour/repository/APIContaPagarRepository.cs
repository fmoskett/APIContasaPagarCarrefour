using APICarrefourContasPagar.Dominio;
using APICarrefourContasPagar.Interface;
using System.Data.Entity;

namespace APIContasaPagarCarrefour.Repository

{
    public class APIContaPagarRepository : IContaPagarRepository
    {
        private readonly DbContext _context;

        public APIContaPagarRepository(DbContext context)
        {
            _context = context;
        }

        public List<ContaPagar> ObterContasPagar()
        {
            return _context.Set<ContaPagar>().ToList();
        }

        public List<ContaPagar> ObterContasPagarDia( DateTime dataPagaento)
        {
            return _context.Set<ContaPagar>().Where( e => e.DataPagamento == dataPagaento).ToList();
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
