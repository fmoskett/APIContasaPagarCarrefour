using APICarrefourContasPagar.Dominio;
using APICarrefourContasPagar.Interface;

namespace APICarrefourContasAPagar.Business
{
    public class buContasAPagar
    {
        public IContaPagarRepository? _contaPagarRepository;

        public IContaPagarRepository ContaPagarService(IContaPagarRepository contaPagarRepository)
        {
            return _contaPagarRepository = contaPagarRepository;
        }

        public List<ContaPagar> ObterContasPagar()
        {
            return _contaPagarRepository.ObterContasPagar();
        }

        public ContaPagar ObterContaPagarPorId(int id)
        {
            return _contaPagarRepository.ObterContaPagarPorId(id);
        }

        public void AdicionarContaPagar(ContaPagar contaPagar)
        {
            _contaPagarRepository.AdicionarContaPagar(contaPagar);
        }

        public void AtualizarContaPagar(ContaPagar contaPagar)
        {
            _contaPagarRepository.AtualizarContaPagar(contaPagar);
        }

        public void RemoverContaPagar(int id)
        {
            _contaPagarRepository.RemoverContaPagar(id);
        }

    }
}
