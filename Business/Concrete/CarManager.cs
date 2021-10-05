using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _cars;

        public CarManager(ICarDal cars)
        {
            _cars = cars;
        }

        public List<Car> GetAll()
        {
            return _cars.GetAll();
        }

        public List<Car> GetByCarName()
        {
            return _cars.GetAll().FindAll(c => c.Description.Length > 2);
        }

        public List<Car> GetByUnitPrice(decimal min)
        {
            return _cars.GetAll(c => c.DailyPrice > min);
        }
    }
}
