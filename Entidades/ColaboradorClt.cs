namespace Colaborador.Entidades
{
    class ColaboradorClt
    {
        public string Nome { get; set; }
        public double Horas { get; set; }
        public double ValorPorHora { get; set; }

        public ColaboradorClt()
        {
        }
        public ColaboradorClt(string nome, double horas,  double valorPorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorPorHora = valorPorHora;
        }

        public virtual double Pagamento()
        {
            return Horas * ValorPorHora;
        }
    }
}
