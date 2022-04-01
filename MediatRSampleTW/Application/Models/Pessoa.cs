using System;

namespace MediatRSampleTW.Repositories
{
    public class Pessoa 
    {
        public Pessoa()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
    }
}
