using System.Collections.Generic;
using System.Threading.Tasks;
using Entity.Interfaces;

namespace Infrastructure
{
    public class GenericRepository<T> : IGenericRepository<T>
    {
        public Task<T> GetIdAsync(dynamic id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IReadOnlyList<T>> ListAllAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}