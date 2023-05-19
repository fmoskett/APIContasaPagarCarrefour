using APICarrefourContasPagar.Dominio;
using APICarrefourContasPagar.Interface;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel;

namespace APIContasaPagarCarrefour.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IContaPagarRepository? _contaPagarRepository;

        [HttpGet("ObterContasPagar")]
        public List<ContaPagar> ObterContasPagar()
        {

        return    _contaPagarRepository.ObterContasPagar();
        }

        [HttpPost("AdicionarContaPagar")]
        public void AdicionarContaPagar(int Id, DateTime dateVencimento, DateTime datePagamento,  string fornecedor, decimal valor, bool pago)
        {
            ContaPagar contaPagar = new ContaPagar();
            contaPagar.DataVencimento = dateVencimento;
            contaPagar.Fornecedor = fornecedor;
            contaPagar.Valor = valor;
            contaPagar.Pago = pago;
            contaPagar.Id = Id;
            contaPagar.DataPagamento = datePagamento;
            _contaPagarRepository.AdicionarContaPagar(contaPagar);
        }
        [HttpPost("AtualizarContaPagar")]
        [Description("Atualização de Contas a Pagar")]
        [SwaggerOperation(OperationId = "Atualização de Contas a Pagar")]
        public void AtualizarContaPagar(int Id, DateTime dateVencimento, DateTime datePagamento, string fornecedor, decimal valor, bool pago)

        {
            ContaPagar contaPagar = new ContaPagar();
            contaPagar.DataVencimento = dateVencimento;
            contaPagar.Fornecedor = fornecedor;
            contaPagar.Valor = valor;
            contaPagar.Pago = pago;
            contaPagar.Id = Id;
            contaPagar.DataPagamento = datePagamento;

            _contaPagarRepository.AtualizarContaPagar(contaPagar);
        }
        [HttpPost("RemoverContaPagar")]
        public void RemoverContaPagar(int id)
        {
            _contaPagarRepository.RemoverContaPagar(id);
        }

        [HttpPost("ObterConsolidadoDiario")]
        public List<ContaPagar>  ObterConsolidadoDiario(DateTime dataPagamento)
        {
          return   _contaPagarRepository.ObterContasPagarDia(dataPagamento).ToList();
        }
    }
}