using Colaborador.Entidades.Execao;
namespace Colaborador.Entidades
{
    class ColaboradorClt
    {
        public string Nome { get; set; }
        public double Horas { get; set; }
        public double ValorPorHora { get; set; }
        public char tipoColaborador { get; set; }

        public ColaboradorClt(char tipoColaborador)
        {
            if (tipoColaborador == 'S' || tipoColaborador == 'N')
            {
                this.tipoColaborador = tipoColaborador;
            }
            else
            {
                throw new ExecaoDominio("Aceito somente S ou N");
            }
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
