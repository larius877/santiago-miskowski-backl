using api.Entities;
using api.Models;
using api.Services;

namespace api
{
    public interface ICarService
    {
        public Task<ICollection<CarEntity>> GetAll();
        public Task<ICollection<CarEntity>> Get(int id);
        public Task<bool> Register(CarEntity car);
        public Task<bool> Delete(int id);
        public Task<bool> Edit(CarEntity car);

    }
}
