using System;
using MediatR;

namespace MediatRSampleTW.Commands
{
    public class AlteraPessoaCommand : IRequest<string>
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }  
        public char Sexo { get; set; }
    }
}