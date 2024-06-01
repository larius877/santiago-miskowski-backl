using api.Entities;
using api.Interfaces;

namespace api.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public Task<ICollection<CarEntity>> GetAll()
        {
            return _carRepository.GetAll();
        }

        public Task<ICollection<CarEntity>> Get(int id)
        {
            return _carRepository.Get(id);
        }

        public Task<bool> Register(CarEntity car)
        {
            return _carRepository.Register(car);
        }
        public Task<bool> Edit(CarEntity car)
        {
            return _carRepository.Edit(car);
        }
        public Task<bool> Delete(int id)
        {
            return _carRepository.Delete(id);
        }

    }
}