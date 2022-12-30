using System;


namespace Colaborador.Entidades.Execao
{
    internal class ExecaoDominio : ApplicationException
    {
        public ExecaoDominio(string message) : base(message)
        {

        }
    }
}
