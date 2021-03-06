using System;
using MediatR;

namespace MediatRSampleTW.Notifications 
{
    public class PessoaAlteradaNotification : INotification
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
        public bool IsEfetivado { get; set; }
    }
}