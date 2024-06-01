using System.Collections.ObjectModel;
using api.Interfaces;
using api.Entities;

using Microsoft.EntityFrameworkCore;

namespace api.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDbContext _dbContext;

        public CarRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ICollection<CarEntity>> GetAll()
        {
            return await _dbContext.cars.ToListAsync();
        }

        public async Task<ICollection<CarEntity>> Get(int id)
        {
            var car = await _dbContext.cars.FindAsync(id);
            if (car != null)
            {
                return new Collection<CarEntity> { car };
            }
            return new Collection<CarEntity>();
        }
        public async Task<bool> Register(CarEntity car)
        {
            await _dbContext.cars.AddAsync(car);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Edit(CarEntity car)
        {
            _dbContext.Entry(car).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var carToDelete = await _dbContext.cars.FindAsync(id);
            if (carToDelete != null)
            {
                _dbContext.cars.Remove(carToDelete);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
