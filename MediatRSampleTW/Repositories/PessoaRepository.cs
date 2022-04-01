using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRSampleTW.Repositories
{
    public class PessoaRepository : IRepository<Pessoa>
    {
        private static Dictionary<Guid, Pessoa> pessoas = new Dictionary<Guid, Pessoa>();

        public async Task<IEnumerable<Pessoa>> GetAll(){
            return await Task.Run(() => pessoas.Values.ToList());
        }

        public async Task<Pessoa> Get(Guid id){
            return await Task.Run(() => pessoas.GetValueOrDefault(id));
        }

        public async Task Add(Pessoa pessoa){
            await Task.Run(() => pessoas.Add(pessoa.Id, pessoa));
        }

        public async Task Edit(Pessoa pessoa){
            await Task.Run(() =>
            {
                pessoas.Remove(pessoa.Id);
                pessoas.Add(pessoa.Id, pessoa);
            });
        }

        public async Task Delete(Guid id){
            await Task.Run(() => pessoas.Remove(id));
        }
    }
}
