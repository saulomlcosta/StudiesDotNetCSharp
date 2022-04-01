using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MediatRSampleTW.Commands;
using MediatRSampleTW.Notifications;
using MediatRSampleTW.Repositories;

namespace MediatRSampleTW.Handlers
{
    public class AlteraPessoaCommandHandler : IRequestHandler<AlteraPessoaCommand, string>
    {
        private readonly IMediator _mediator;
        private readonly IRepository<Pessoa> _repository;
        public AlteraPessoaCommandHandler(IMediator mediator, IRepository<Pessoa> repository)
        {
            this._mediator = mediator;
            this._repository = repository;
        }

        public async Task<string> Handle(AlteraPessoaCommand request, CancellationToken cancellationToken)
        {
            var pessoa = new Pessoa { Nome = request.Nome, Idade = request.Idade, Sexo = request.Sexo };

            try 
            {
                await _repository.Edit(pessoa);

                await _mediator.Publish(
                    new PessoaAlteradaNotification  
                    { 
                        Id = pessoa.Id, 
                        Nome = pessoa.Nome, 
                        Idade = pessoa.Idade, 
                        Sexo = pessoa.Sexo,
                        IsEfetivado = true 
                    });

                return await Task.FromResult("Pessoa criada com sucesso");
            } catch (Exception ex) {
                await _mediator.Publish(
                    new PessoaAlteradaNotification  
                    { 
                        Id = pessoa.Id, 
                        Nome = pessoa.Nome, 
                        Idade = pessoa.Idade, 
                        Sexo = pessoa.Sexo,
                        IsEfetivado = false 
                    });

                await _mediator.Publish(new ErrorNotification { Excecao = ex.Message, PilhaErro = ex.StackTrace});
                return await Task.FromResult("Ocorreu um erro no momento da alteração");
            }
        }
    }
}