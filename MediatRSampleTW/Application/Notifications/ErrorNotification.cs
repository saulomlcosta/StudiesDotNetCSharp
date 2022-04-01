using MediatR;

namespace MediatRSampleTW.Notifications
{
    public class ErrorNotification : INotification
    {
        public string Excecao { get; set; }
        public string PilhaErro { get; set; }
    }
}