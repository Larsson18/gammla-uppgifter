using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bil2
{
    public class CarRegister
    {
        // en vanlig lista utav Car
         public List<Car> Cars { get; set; } = new List<Car>();

        // en metod med indataparameter car
        public bool AddCar(Car car) 
        // lägger till bilen till listan av bilar
        {
            Cars.Add(car);
            return true;
        }

    }
}
