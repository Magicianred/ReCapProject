using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car { CarId = 1, CarName="M3" , BrandId = 1, ColorId = 1, ModelYear = 1998, DailyPrice = 120, Description = "Sürtesinki zevk alasın"},
                new Car { CarId = 2, CarName="Astra" , BrandId = 3, ColorId = 1, ModelYear = 2015, DailyPrice = 250, Description = "Az yakar çok kaçar" },
                new Car { CarId = 3, CarName="M5" , BrandId = 1, ColorId = 2, ModelYear = 2000, DailyPrice = 150, Description = "Modifiyeli" },
                new Car { CarId = 4, CarName="Insignia" , BrandId = 3, ColorId = 2, ModelYear = 2020, DailyPrice = 320, Description = "Konforu bol" },
                new Car { CarId = 5, CarName="Clio" , BrandId = 2, ColorId = 3, ModelYear = 2011, DailyPrice = 200, Description = "Full + Full" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //use linq
            Car carToDelete = _cars.SingleOrDefault(p=>p.CarId == car.CarId);

        }

        public List<Car> GetAll()
        {

            return _cars;

        }

        public List<Car> GetAllByBrandId(int brandId)
        {

            return _cars.Where(p => p.BrandId == brandId).ToList();

        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.CarName = car.CarName;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            
        }
    }
}
