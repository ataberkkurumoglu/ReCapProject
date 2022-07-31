using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _cardal;

        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice > 0)
            {
                _cardal.Add(car);
            }
                
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cardal.GetAll();
        }

        public Car GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _cardal.GetAll(c => c.BrandId == id).ToList();
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _cardal.GetAll(c => c.ColorId == id).ToList();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
