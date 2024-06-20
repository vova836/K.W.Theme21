using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    /// <summary>
    /// Класс для хранения информации о водителях
    /// </summary>
    class TaxiInfo
    {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string CarNumber { get; set; }
            public CarType CarType { get; set; }

        /// <summary>
        /// Конструктор для инициализации данных водителях
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="carNumber"></param>
        /// <param name="carType"></param>

        public TaxiInfo(string firstName, string lastName, string carNumber, CarType carType)
        {
            FirstName = firstName;
            LastName = lastName;
            CarNumber = carNumber;
            CarType = carType;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - Номер Автомобиля {CarNumber} ({CarType} Класс Автомобиля)";
        }
    }
}
