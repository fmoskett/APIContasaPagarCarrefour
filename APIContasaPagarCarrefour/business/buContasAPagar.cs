using APICarrefourContasPagar.Dominio;
using APICarrefourContasPagar.Interface;
using APIContasaPagarCarrefour.dominio;
using APIContasaPagarCarrefour.Repository;
using log4net;

namespace APICarrefourContasAPagar.Business
{
    public class buContasAPagar
    {
        public IContaPagarRepository _contaPagarRepository = new APIContaPagarRepository();
        private static readonly ILog _loggerService = LogManager.GetLogger(typeof(buContasAPagar));


        public IContaPagarRepository ContaPagarService(IContaPagarRepository contaPagarRepository)
        {
            try
            {
                return _contaPagarRepository = contaPagarRepository;
            }
            catch (Exception ex)
            {
                // Registro da exceção
                _loggerService.Error("Ocorreu uma exceção durante a execução. " + ex + "  ContaPagarService");
                throw new Exception("Ocorreu um erro!");

            }
        }

        //ObterContasPagarDia
        public List<ResultadoContaPagar> ObterContasPagarDia(DateTime dataPagamento)
        {
            try
            {
                return _contaPagarRepository.ObterContasPagarDia(dataPagamento);
            }
            catch (Exception ex)
            {
                // Registro da exceção
                _loggerService.Error("Ocorreu uma exceção durante a execução. " + ex + "  ObterContasPagarDia");
                throw new Exception("Ocorreu um erro!");

            }
        }




        public List<ContaPagar> ObterContasPagar()
        {
            try
            {
                return _contaPagarRepository.ObterContasPagar();

            }
            catch (Exception ex)
            {
                // Registro da exceção
                _loggerService.Error("Ocorreu uma exceção durante a execução. " + ex + "  ObterContasPagar");
                throw new Exception("Ocorreu um erro!");

            }
        }

        public void AdicionarContaPagar(ContaPagar contaPagar)
        {
            try
            {
                APIContaPagarRepository addRepos = new();
                addRepos.AdicionarContaPagar(contaPagar);
                _loggerService.Info("Inclusão com sucesso!");
            }
            catch (Exception ex)
            {
                // Registro da exceção
                _loggerService.Error("Ocorreu uma exceção durante a execução. " + ex + "  AdicionarContaPagar");
                throw new Exception("Ocorreu um erro!");

            }
        }


        public void AtualizarContaPagar(ContaPagar contaPagar)
        {
            try
            {
                _contaPagarRepository.AtualizarContaPagar(contaPagar);
                _loggerService.Info("Atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                // Registro da exceção
                _loggerService.Error("Ocorreu uma exceção durante a execução. " + ex + "  AdicionarContaPagar");
                throw new Exception("Ocorreu um erro!");

            }
        }


        public void RemoverContaPagar(int id)
        {
            try
            {
                _contaPagarRepository.RemoverContaPagar(id);
                _loggerService.Info("Removido com sucesso!");
            }
            catch (Exception ex)
            {
                // Registro da exceção
                _loggerService.Error("Ocorreu uma exceção durante a execução. " + ex + "  AdicionarContaPagar");
                throw new Exception("Ocorreu um erro!");

            }


        }
    }
}
