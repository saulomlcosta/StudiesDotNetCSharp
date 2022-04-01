using System;
using MediatR;

namespace MediatRSampleTW.Notifications 
{
    public class PessoaCriadaNotification : INotification
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
    }

}