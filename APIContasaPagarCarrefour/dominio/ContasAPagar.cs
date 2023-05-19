namespace APICarrefourContasPagar.Dominio
{
    public class ContaPagar
    {
        public int Id { get; set; }
        public string? Fornecedor { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public bool Pago { get; set; }
    }

}
