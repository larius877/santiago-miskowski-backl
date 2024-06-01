using AutoMapper;
using api.Models;
using api.Entities;

namespace api;

public class CarProfile : Profile
{
    public CarProfile()
    {
        CreateMap<Car, CarEntity>().ReverseMap();
    }
}