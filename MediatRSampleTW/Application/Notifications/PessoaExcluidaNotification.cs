using System;
using MediatR;

namespace MediatRSampleTW.Notifications 
{
    public class PessoaExcluidaNotification : INotification
    {
        public Guid Id { get; set; }
        public bool IsEfetivado { get; set; }
    }

}