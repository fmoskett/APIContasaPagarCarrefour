using APICarrefourContasPagar.Dominio;
using APIContasaPagarCarrefour.dominio;

namespace APICarrefourContasPagar.Interface
{
    public interface IContaPagarRepository
    {
        List<ContaPagar> ObterContasPagar();
        List<ResultadoContaPagar> ObterContasPagarDia( DateTime dataPagamento);
        ContaPagar ObterContaPagarPorId(int id);
        void AdicionarContaPagar(ContaPagar contaPagar);
        void AtualizarContaPagar(ContaPagar contaPagar);
        void RemoverContaPagar(int id);
    }

}
