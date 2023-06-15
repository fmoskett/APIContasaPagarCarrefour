using APICarrefourContasPagar.Dominio;
using APICarrefourContasPagar.Interface;
using APIContasaPagarCarrefour.Repository;

namespace APICarrefourContasAPagar.Business
{
    public class buContasAPagar
    {
        public IContaPagarRepository _contaPagarRepository = new APIContaPagarRepository();

        public IContaPagarRepository ContaPagarService(IContaPagarRepository contaPagarRepository)
        {
            return _contaPagarRepository = contaPagarRepository;
        }

        //ObterContasPagarDia
        public List<ContaPagar> ObterContasPagarDia( DateTime dataPagamento)
        {

            return _contaPagarRepository.ObterContasPagarDia( dataPagamento);
        }

        public List<ContaPagar> ObterContasPagar()
        {

                return _contaPagarRepository.ObterContasPagar();
        }

        public void AdicionarContaPagar(ContaPagar contaPagar)
        {
            APIContaPagarRepository addRepos = new();
            addRepos.AdicionarContaPagar(contaPagar);
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
