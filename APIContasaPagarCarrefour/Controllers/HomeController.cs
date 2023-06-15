using APICarrefourContasAPagar.Business;
using APICarrefourContasPagar.Dominio;
using APIContasaPagarCarrefour.interfaces;
using APIContasaPagarCarrefour.repository;
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
        public buContasAPagar _contaPagar = new buContasAPagar();

        [HttpGet("ObterContasPagar")]
        public List<ContaPagar> ObterContasPagar()
        {

            return _contaPagar.ObterContasPagar();
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
            _contaPagar.AdicionarContaPagar(contaPagar);
        }
        [HttpPost("AtualizarContaPagar")]
        [Description("Atualiza��o de Contas a Pagar")]
        [SwaggerOperation(OperationId = "Atualiza��o de Contas a Pagar")]
        public void AtualizarContaPagar(int Id, DateTime dateVencimento, DateTime datePagamento, string fornecedor, decimal valor, bool pago)

        {
            ContaPagar contaPagar = new ContaPagar();
            contaPagar.DataVencimento = dateVencimento;
            contaPagar.Fornecedor = fornecedor;
            contaPagar.Valor = valor;
            contaPagar.Pago = pago;
            contaPagar.Id = Id;
            contaPagar.DataPagamento = datePagamento;

            _contaPagar.AtualizarContaPagar(contaPagar);
        }
        [HttpPost("RemoverContaPagar")]
        public void RemoverContaPagar(int id)
        {
            _contaPagar.RemoverContaPagar(id);
        }

        [HttpPost("ObterConsolidadoDiario")]
        public decimal ObterConsolidadoDiario(DateTime dataPagamento)
        {
          return _contaPagar.ObterContasPagarDia(dataPagamento).ToList();
        }
    }
}
