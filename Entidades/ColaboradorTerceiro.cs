namespace Colaborador.Entidades
{
    internal class ColaboradorTerceiro : ColaboradorClt
    {
        public double Adcional { get; set; }

        
        public ColaboradorTerceiro(string nome, double horas, double valorPorHora, double adcional) 
            : base(nome, horas, valorPorHora)
        {
            Adcional = adcional;
        }
        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * Adcional;
        }
    }
}
