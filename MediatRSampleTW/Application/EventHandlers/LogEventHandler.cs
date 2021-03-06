using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MediatRSampleTW.Notifications;

namespace MediatRSampleTW.EventHandlers
{
    public class LogEventHandler :
                            INotificationHandler<PessoaCriadaNotification>,
                            INotificationHandler<PessoaAlteradaNotification>,
                            INotificationHandler<PessoaExcluidaNotification>,
                            INotificationHandler<ErrorNotification>
    {
        public Task Handle(PessoaCriadaNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"CRIACAO: '{notification.Id} - {notification.Nome} - {notification.Idade} - {notification.Sexo}'");
            });
        }

        public Task Handle(PessoaAlteradaNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"ALTERACAO: '{notification.Id} - {notification.Nome} - {notification.Idade} - {notification.Sexo} - {notification.IsEfetivado}'");
            });
        }

        public Task Handle(PessoaExcluidaNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"EXCLUSAO: '{notification.Id} - {notification.IsEfetivado}'");
            });
        }

        public Task Handle(ErrorNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"ERRO: '{notification.Excecao} \n {notification.PilhaErro}'");
            });
        }
    }
}