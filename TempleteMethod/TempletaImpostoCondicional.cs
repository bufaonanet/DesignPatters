namespace TempleteMethod
{
    public abstract class TempletaImpostoCondicional : IImposto
    {
        public double CalcularImposto(Orcamento orcamento)
        {
            if (DeveUsarTaxacaoMaxima(orcamento))
            {
                return TaxacaoMaxima(orcamento);
            }
            else
            {
                return TaxacaoMinima(orcamento);
            }
        }

        protected abstract bool DeveUsarTaxacaoMaxima(Orcamento orcamento);
        protected abstract double TaxacaoMinima(Orcamento orcamento);
        protected abstract double TaxacaoMaxima(Orcamento orcamento);

        
    }
}
