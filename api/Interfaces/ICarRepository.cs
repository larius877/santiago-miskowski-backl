using api.Entities;

namespace api.Interfaces
{
    public interface ICarRepository
    {  
        public Task<ICollection<CarEntity>> GetAll();
        public Task<ICollection<CarEntity>> Get(int id);
        public Task<bool> Register(CarEntity car);
        public Task<bool> Edit(CarEntity car);
        public Task<bool> Delete(int id);
    }
}
