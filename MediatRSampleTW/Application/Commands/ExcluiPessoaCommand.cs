using System;
using MediatR;

public class ExcluiPessoaCommand : IRequest<string>
{
    public Guid Id { get; set; }
}