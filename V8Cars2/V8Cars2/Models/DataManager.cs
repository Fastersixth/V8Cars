using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using V8Cars2.Models.ViewModels;

namespace V8Cars2.Models
{
    public class DataManager
    {
        private static List<Car> cars = new List<Car>(); 

        public static void AddCar(CarsCreateVM viewModel)
        {
            var car = new Car()
            {
                Brand = viewModel.Brand,
                Doors = viewModel.Doors,
                TopSpeed = viewModel.TopSpeed,
            };
            if (cars.Count > 0)
                car.Id = cars.Max(c => c.Id) + 1;
            else
                car.Id = 1;
            cars.Add(car);
        }

        public static CarsIndexVM[] ListCars()
        {
            return cars.Select(c => new CarsIndexVM()
            {
                Brand = c.Brand,
                ShowAsFast = c.TopSpeed > 250
            }).ToArray();
        }
    }
}
